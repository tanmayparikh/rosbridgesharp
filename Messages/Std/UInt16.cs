using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Std
{
    public class UInt16 : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/UInt16";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("data")]
        public ushort Data { get; set; }

        public UInt16()
        {
            Data = 0;
        }

        public UInt16(ushort data)
        {
            Data = data;
        }
    }
}
