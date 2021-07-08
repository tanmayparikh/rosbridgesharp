using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Geometry
{
    public class Pose : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "geometry_msgs/Pose";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("position")]
        public Point Position { get; set; }

        [JsonProperty("orientation")]
        public Quaternion Orientation { get; set; }

        public Pose()
        {
            Position = new Point();
            Orientation = new Quaternion();
        }

        public Pose(Point position, Quaternion orientation)
        {
            Position = position;
            Orientation = orientation;
        }
    }
}
