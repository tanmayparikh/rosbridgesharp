using Newtonsoft.Json;

namespace Rosbridgenet.Services.RosApi
{
    public class SetParamRequest : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "rosapi/SetParam";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        public SetParamRequest()
        {
            Name = string.Empty;
            Value = string.Empty;
        }

        public SetParamRequest(string name, string value)
        {
            Name = name;
            Value = value;
        }
    }
}
