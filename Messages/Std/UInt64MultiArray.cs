using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace rosbridgenet.Messages.Std
{
    public class UInt64MultiArray : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/UInt64MultiArray";

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
        public ulong[] Data { get; set; }

        public UInt64MultiArray()
        {
            Layout = new MultiArrayLayout();
            Data = new ulong[0];
        }

        public UInt64MultiArray(MultiArrayLayout layout, ulong[] data)
        {
            Layout = layout;
            Data = data;
        }
    }
}
