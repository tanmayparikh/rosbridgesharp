using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Std
{
    public class Int32 : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/Int32";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("data")]
        public int Data { get; set; }

        public Int32()
        {
            Data = 0;
        }

        public Int32(int data)
        {
            Data = data;
        }
    }
}
