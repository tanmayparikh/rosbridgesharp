using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Std
{
    public class Float32MultiArray : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/Float32MultiArray";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("layout")]
        public MultiArrayLayout Layout { get; set; }

        [JsonProperty("data")]
        public float[] Data { get; set; }

        public Float32MultiArray()
        {
            Layout = new MultiArrayLayout();
            Data = new float[0];
        }

        public Float32MultiArray(MultiArrayLayout layout, float[] data)
        {
            Layout = layout;
            Data = data;
        }
    }
}
