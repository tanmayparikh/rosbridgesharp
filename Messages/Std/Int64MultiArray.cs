using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace rosbridgenet.Messages.Std
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

        [JsonInclude]
        [JsonPropertyName("layout")]
        public MultiArrayLayout Layout { get; set; }

        [JsonInclude]
        [JsonPropertyName("data")]
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
