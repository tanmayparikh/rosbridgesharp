using Rosbridgenet.Messages.Std;
using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Geometry
{
    public class PoseStamped : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "geometry_msgs/PoseStamped";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("header")]
        public Header Header { get; set; }

        [JsonProperty("pose")]
        public Pose Pose { get; set; }

        public PoseStamped()
        {
            Header = new Header();
            Pose = new Pose();
        }

        public PoseStamped(Header header, Pose pose)
        {
            Header = header;
            Pose = pose;
        }
    }
}
