using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Std
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

        [JsonProperty("layout")]
        public MultiArrayLayout Layout { get; set; }

        [JsonProperty("data")]
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