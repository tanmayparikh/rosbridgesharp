using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Geometry
{
    public class Point : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "geometry_msgs/Point";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }

        [JsonProperty("z")]
        public double Z { get; set; }

        public Point()
        {
            X = Y = Z = 0d;
        }

        public Point(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
