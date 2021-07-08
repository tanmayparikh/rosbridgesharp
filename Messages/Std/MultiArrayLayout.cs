using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Std
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

        [JsonProperty("dim")]
        public MultiArrayDimension[] Dim { get; set; }

        [JsonProperty("data_offset")]
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
