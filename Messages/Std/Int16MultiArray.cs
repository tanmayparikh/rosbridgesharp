using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace rosbridgenet.Messages.Std
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

        [JsonInclude]
        [JsonPropertyName("layout")]
        public MultiArrayLayout Layout { get; set; }

        [JsonInclude]
        [JsonPropertyName("data")]
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
