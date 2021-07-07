using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace rosbridgenet.Messages.Std
{
    public class MultiArrayLayout : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/MultiArrayLayout";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonIgnore]
        [JsonPropertyName("dim")]
        public MultiArrayDimension[] Dim { get; set; }

        [JsonIgnore]
        [JsonPropertyName("data_offset")]
        public uint DataOffset { get; set; }

        public MultiArrayLayout()
        {
            Dim = new MultiArrayDimension[0];
            DataOffset = 0;
        }

        public MultiArrayLayout(MultiArrayDimension[] dim, uint dataOffset)
        {
            Dim = dim;
            DataOffset = dataOffset;
        }
    }
}
