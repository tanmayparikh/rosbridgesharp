using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Std
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

        [JsonProperty("label")]
        public string Label { get; set; }
        
        [JsonProperty("size")]
        public uint Size { get; set; }
        
        [JsonProperty("stride")]
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
