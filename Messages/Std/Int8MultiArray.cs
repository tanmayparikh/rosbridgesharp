using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Std
{
    public class Int8MultiArray : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/Int8MultiArray";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("layout")]
        public MultiArrayLayout Layout { get; set; }

        [JsonProperty("data")]
        public sbyte[] Data { get; set; }

        public Int8MultiArray()
        {
            Layout = new MultiArrayLayout();
            Data = new sbyte[0];
        }

        public Int8MultiArray(MultiArrayLayout layout, sbyte[] data)
        {
            Layout = layout;
            Data = data;
        }
    }
}
