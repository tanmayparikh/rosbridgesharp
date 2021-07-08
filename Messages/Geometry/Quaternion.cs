using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Geometry
{
    public class Quaternion : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "geometry_msgs/Quaternion";

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

        [JsonProperty("w")]
        public double W { get; set; }

        public Quaternion()
        {
            X = Y = Z = W = 0d;
        }

        public Quaternion(double x, double y, double z, double w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }
    }
}
