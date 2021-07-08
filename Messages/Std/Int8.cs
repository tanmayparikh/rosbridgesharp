using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Std
{
    public class Int8 : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/Int8";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("data")]
        public sbyte Data { get; set; }

        public Int8()
        {
            Data = 0;
        }

        public Int8(sbyte data)
        {
            Data = data;
        }
    }
}
