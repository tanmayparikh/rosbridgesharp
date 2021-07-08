using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Std
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

        [JsonProperty("layout")]
        public MultiArrayLayout Layout { get; set; }

        [JsonProperty("data")]
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
