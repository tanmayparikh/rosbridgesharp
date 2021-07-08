using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Std
{
    public class Int64MultiArray : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/Int64MultiArray";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("layout")]
        public MultiArrayLayout Layout { get; set; }

        [JsonProperty("data")]
        public long[] Data { get; set; }

        public Int64MultiArray()
        {
            Layout = new MultiArrayLayout();
            Data = new long[0];
        }

        public Int64MultiArray(MultiArrayLayout layout, long[] data)
        {
            Layout = layout;
            Data = data;
        }
    }
}
