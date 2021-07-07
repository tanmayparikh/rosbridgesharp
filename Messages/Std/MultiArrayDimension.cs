using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace rosbridgenet.Messages.Std
{
    public class MultiArrayDimension : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/MultiArrayDimension";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonIgnore]
        [JsonPropertyName("label")]
        public string Label { get; set; }
        
        [JsonIgnore]
        [JsonPropertyName("size")]
        public uint Size { get; set; }
        
        [JsonIgnore]
        [JsonPropertyName("stride")]
        public uint Stride { get; set; }

        public MultiArrayDimension()
        {
            Label = string.Empty;
            Size = 0;
            Stride = 0;
        }

        public MultiArrayDimension(string label, uint size, uint stride)
        {
            Label = label;
            Size = size;
            Stride = stride;
        }
    }
}
