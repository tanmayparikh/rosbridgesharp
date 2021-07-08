using Newtonsoft.Json;

namespace Rosbridgenet.Services.RosApi
{
    public class GetParamResponse : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "rosapi/GetParam";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("value")]
        public string Value { get; set; }

        public GetParamResponse()
        {
            Value = string.Empty;
        }

        public GetParamResponse(string value)
        {
            Value = value;
        }
    }
}
