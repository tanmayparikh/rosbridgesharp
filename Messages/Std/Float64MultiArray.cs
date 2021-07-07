using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace rosbridgenet.Messages.Std
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

        [JsonInclude]
        [JsonPropertyName("layout")]
        public MultiArrayLayout Layout { get; set; }

        [JsonInclude]
        [JsonPropertyName("data")]
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
