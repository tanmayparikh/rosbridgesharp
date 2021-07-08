using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Std
{
    public class Int16MultiArray : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/Int16MultiArray";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("layout")]
        public MultiArrayLayout Layout { get; set; }

        [JsonProperty("data")]
        public short[] Data { get; set; }

        public Int16MultiArray()
        {
            Layout = new MultiArrayLayout();
            Data = new short[0];
        }

        public Int16MultiArray(MultiArrayLayout layout, short[] data)
        {
            Layout = layout;
            Data = data;
        }
    }
}
