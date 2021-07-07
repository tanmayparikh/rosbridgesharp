using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace rosbridgenet.Messages.Std
{
    public class ByteMultiArray : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/ByteMultiArray";

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

        public ByteMultiArray()
        {
            Layout = new MultiArrayLayout();
            Data = new byte[0];
        }

        public ByteMultiArray(MultiArrayLayout layout, byte[] data)
        {
            Layout = layout;
            Data = data;
        }
    }
}