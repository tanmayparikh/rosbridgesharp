using Rosbridgenet.Messages.Std;
using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Geometry
{
    public class PoseWithCovarianceStamped : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "geometry_msgs/PoseWithCovarianceStamped";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("header")]
        public Header Header { get; set; }

        [JsonProperty("pose")]
        public PoseWithCovariance Pose { get; set; }

        public PoseWithCovarianceStamped()
        {
            Header = new Header();
            Pose = new PoseWithCovariance();
        }

        public PoseWithCovarianceStamped(Header header, PoseWithCovariance pose)
        {
            Header = header;
            Pose = pose;
        }
    }
}
