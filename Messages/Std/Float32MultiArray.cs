using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace rosbridgenet.Messages.Std
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

        [JsonInclude]
        [JsonPropertyName("layout")]
        public MultiArrayLayout Layout { get; set; }

        [JsonInclude]
        [JsonPropertyName("data")]
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
