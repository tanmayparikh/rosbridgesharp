using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace rosbridgenet.Messages.Std
{
    public class Int8MultiArray : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/Int8MultiArray";

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
        public sbyte[] Data { get; set; }

        public Int8MultiArray()
        {
            Layout = new MultiArrayLayout();
            Data = new sbyte[0];
        }

        public Int8MultiArray(MultiArrayLayout layout, sbyte[] data)
        {
            Layout = layout;
            Data = data;
        }
    }
}
