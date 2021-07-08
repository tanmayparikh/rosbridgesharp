using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Std
{
    public class Char : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/Char";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("data")]
        public char Data { get; set; }

        public Char()
        {
            Data = '\0';
        }

        public Char(char data)
        {
            Data = data;
        }
    }
}
