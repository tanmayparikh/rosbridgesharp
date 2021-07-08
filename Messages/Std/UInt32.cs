using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Std
{
    public class UInt32 : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/UInt32";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("data")]
        public uint Data { get; set; }

        public UInt32()
        {
            Data = 0;
        }

        public UInt32(uint data)
        {
            Data = data;
        }
    }
}
