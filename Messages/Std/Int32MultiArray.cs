using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Std
{
    public class Int32MultiArray : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/Int32MultiArray";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("layout")]
        public MultiArrayLayout Layout { get; set; }

        [JsonProperty("data")]
        public int[] Data { get; set; }

        public Int32MultiArray()
        {
            Layout = new MultiArrayLayout();
            Data = new int[0];
        }

        public Int32MultiArray(MultiArrayLayout layout, int[] data)
        {
            Layout = layout;
            Data = data;
        }
    }
}
