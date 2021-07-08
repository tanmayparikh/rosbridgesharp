using Rosbridgenet.Messages.Geometry;
using Rosbridgenet.Messages.Std;
using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Nav
{
    public class Path : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "nav_msgs/Path";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("header")]
        public Header Header { get; set; }

        [JsonProperty("poses")]
        public PoseStamped[] Poses { get; set; }

        public Path()
        {
            Header = new Header();
            Poses = new PoseStamped[0];
        }

        public Path(Header header, PoseStamped[] poses)
        {
            Header = header;
            Poses = poses;
        }
    }
}
