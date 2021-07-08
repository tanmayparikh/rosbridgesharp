using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Std
{
    public class Int16 : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/Int16";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("data")]
        public short Data { get; set; }

        public Int16()
        {
            Data = 0;
        }

        public Int16(short data)
        {
            Data = data;
        }
    }
}
