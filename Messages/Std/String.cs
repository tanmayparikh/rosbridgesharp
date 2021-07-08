using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Std
{
    public class String : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/String";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("data")]
        public string Data { get; set; }

        public String()
        {
            Data = string.Empty;
        }

        public String(string data)
        {
            Data = data;
        }
    }
}
