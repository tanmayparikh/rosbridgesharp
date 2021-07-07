using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace rosbridgenet.Messages.Std
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

        [JsonInclude]
        [JsonPropertyName("layout")]
        public MultiArrayLayout Layout { get; set; }

        [JsonInclude]
        [JsonPropertyName("data")]
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
