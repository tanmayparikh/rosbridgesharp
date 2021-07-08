using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Std
{
    public class Int64 : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/Int64";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("data")]
        public long Data { get; set; }

        public Int64()
        {
            Data = 0;
        }

        public Int64(long data)
        {
            Data = data;
        }
    }
}
