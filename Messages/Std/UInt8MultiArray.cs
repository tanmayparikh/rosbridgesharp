using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace rosbridgenet.Messages.Std
{
    public class UInt8MultiArray : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/UInt8MultiArray";

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
        public byte[] Data { get; set; }

        public UInt8MultiArray()
        {
            Layout = new MultiArrayLayout();
            Data = new byte[0];
        }

        public UInt8MultiArray(MultiArrayLayout layout, byte[] data)
        {
            Layout = layout;
            Data = data;
        }
    }
}
