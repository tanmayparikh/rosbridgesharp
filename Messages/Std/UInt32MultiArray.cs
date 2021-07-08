using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Std
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

        [JsonProperty("layout")]
        public MultiArrayLayout Layout { get; set; }

        [JsonProperty("data")]
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
