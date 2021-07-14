using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Geometry
{
    public class PoseWithCovariance : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "geometry_msgs/PoseWithCovariance";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("pose")]
        public Pose Pose { get; set; }

        [JsonProperty("covariance")]
        public double[] Covariance { get; set; }

        public PoseWithCovariance()
        {
            Pose = new Pose();
            Covariance = new double[0];
        }

        public PoseWithCovariance(Pose pose, double[] covariance)
        {
            Pose = pose;
            Covariance = covariance;
        }
    }
}
