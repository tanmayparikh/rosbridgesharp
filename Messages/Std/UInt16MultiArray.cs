using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace rosbridgenet.Messages.Std
{
    public class UInt16MultiArray : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/UInt16MultiArray";

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
        public ushort[] Data { get; set; }

        public UInt16MultiArray()
        {
            Layout = new MultiArrayLayout();
            Data = new ushort[0];
        }

        public UInt16MultiArray(MultiArrayLayout layout, ushort[] data)
        {
            Layout = layout;
            Data = data;
        }
    }
}
