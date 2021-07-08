using Newtonsoft.Json;

namespace Rosbridgenet.Services.RosApi
{
    public class GetParamNamesResponse : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "rosapi/GetParamNames";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("names")]
        public string[] Names { get; set; }

        public GetParamNamesResponse()
        {
            Names = new string[0];
        }

        public GetParamNamesResponse(string[] names)
        {
            Names = names;
        }
    }
}
