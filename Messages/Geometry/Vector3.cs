using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Geometry
{
    public class Vector3 : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "geometry_msgs/Vector3";

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

        public Vector3()
        {
            X = Y = Z = 0d;
        }

        public Vector3(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
