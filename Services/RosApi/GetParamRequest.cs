using Newtonsoft.Json;

namespace Rosbridgenet.Services.RosApi
{
    public class GetParamRequest : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "rosapi/GetParam";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("default")]
        public string Default { get; set; }

        public GetParamRequest()
        {
            Name = string.Empty;
            Default = string.Empty;
        }

        public GetParamRequest(string name, string defaultValue)
        {
            Name = name;
            Default = defaultValue;
        }
    }
}
