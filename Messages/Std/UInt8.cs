using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Std
{
    public class UInt8 : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/UInt8";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("data")]
        public byte Data { get; set; }

        public UInt8()
        {
            Data = 0;
        }

        public UInt8(byte data)
        {
            Data = data;
        }
    }
}
