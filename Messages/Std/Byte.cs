using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Std
{
    public class Byte : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/Byte";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("data")]
        public byte Data { get; set; }

        public Byte()
        {
            Data = 0;
        }

        public Byte(byte data)
        {
            Data = data;
        }
    }
}