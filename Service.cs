using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace Rosbridgenet
{
    public abstract class Service
    {
        public abstract string ServiceName { get; }
        
        public abstract bool HandleServiceCallResponse(string jsonData);
    }

    public class Service<Targ, Tresp> : Service where Targ : Message where Tresp : Message
    {
        public delegate void ServiceResponseHandler(bool result, Tresp response);

        public override string ServiceName { get; }
        public ServiceResponseHandler ResponseHandler { get; set; }

        public Service(string serviceName)
        {
            ServiceName = serviceName;
        }

        public Service(string serviceName, ServiceResponseHandler responseHandler)
        {
            ServiceName = serviceName;
            ResponseHandler = responseHandler;
        }

        public string BuildServiceCallMsg(string id, Targ args)
        {
            var serviceCall = new ServiceCall(
                id,
                ServiceName,
                args);

            return JsonConvert.SerializeObject(serviceCall);
        }

        public string BuildServiceCallMsg(ServiceCall call)
        {
            return JsonConvert.SerializeObject(call);
        }

        public override bool HandleServiceCallResponse(string jsonData)
        {
            var serviceResponse =
                JsonConvert.DeserializeObject<ServiceResponse>(Regex.Unescape(jsonData));
            if (serviceResponse == null)
                return false;

            ResponseHandler?.Invoke(serviceResponse.Result, serviceResponse.Values);

            return true;
        }

        public class ServiceCall : ICommData
        {
            [JsonProperty(RosBridge.FieldOp)]
            public string Operation { get; set; }

            [JsonProperty(RosBridge.FieldId)]
            public string Id { get; set; }

            [JsonProperty(RosBridge.FieldService)]
            public string Service { get; set; }

            [JsonProperty(RosBridge.FieldArgs)]
            public Targ Args { get; set; }

            [JsonProperty(RosBridge.FieldFragmentSize)]
            public int FragmentSize { get; set; }

            [JsonProperty(RosBridge.FieldCompression)]
            public string Compression { get; set; }

            public ServiceCall(
                string id,
                string service,
                Targ args,
                int fragmentSize = int.MaxValue,
                string compression = RosBridge.CompressionType.NONE)
            {
                Operation = RosBridge.OpCallService;
                Id = id;
                Service = service;
                Args = args;
                FragmentSize = fragmentSize;
                Compression = compression;
            }
        }

        public class ServiceResponse : ICommData
        {
            [JsonProperty(RosBridge.FieldOp)]
            public string Operation { get; set; }

            [JsonProperty(RosBridge.FieldId)]
            public string Id { get; set; }

            [JsonProperty(RosBridge.FieldService)]
            public string Service { get; set; }

            [JsonProperty(RosBridge.FieldValues)]
            public Tresp Values { get; set; }

            [JsonProperty(RosBridge.FieldResult)]
            public bool Result { get; set; }

            public ServiceResponse(string id, string service, Tresp values, bool result)
            {
                Operation = RosBridge.OpServiceResponse;
                Id = id;
                Service = service;
                Values = values;
                Result = result;
            }
        }
    }
}
