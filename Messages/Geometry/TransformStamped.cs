using Rosbridgenet.Messages.Std;
using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Geometry
{
    public class TransformStamped : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "geometry_msgs/TransformStamped";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("header")]
        public Header Header { get; set; }

        [JsonProperty("child_frame_id")]
        public string ChildFrameId { get; set; }

        [JsonProperty("transform")]
        public Transform Transform { get; set; }

        public TransformStamped()
        {
            Header = new Header();
            ChildFrameId = string.Empty;
            Transform = new Transform();
        }

        public TransformStamped(Header header, string childFrameId, Transform transform)
        {
            Header = header;
            ChildFrameId = childFrameId;
            Transform = transform;
        }
    }
}
