using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Std
{
    public class UInt64 : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/UInt64";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("data")]
        public ulong Data { get; set; }

        public UInt64()
        {
            Data = 0;
        }

        public UInt64(ulong data)
        {
            Data = data;
        }
    }
}
