using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Std
{
    public class Float64MultiArray : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/Float64MultiArray";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("layout")]
        public MultiArrayLayout Layout { get; set; }

        [JsonProperty("data")]
        public double[] Data { get; set; }

        public Float64MultiArray()
        {
            Layout = new MultiArrayLayout();
            Data = new double[0];
        }

        public Float64MultiArray(MultiArrayLayout layout, double[] data)
        {
            Layout = layout;
            Data = data;
        }
    }
}
