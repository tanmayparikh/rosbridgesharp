using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace rosbridgenet.Messages.Std
{
    public class UInt32MultiArray : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/UInt32MultiArray";

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
        public uint[] Data { get; set; }

        public UInt32MultiArray()
        {
            Layout = new MultiArrayLayout();
            Data = new uint[0];
        }

        public UInt32MultiArray(MultiArrayLayout layout, uint[] data)
        {
            Layout = layout;
            Data = data;
        }
    }
}
