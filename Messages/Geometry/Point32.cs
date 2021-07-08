using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Geometry
{
    public class Point32 : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "geometry_msgs/Point32";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("x")]
        public float X { get; set; }

        [JsonProperty("y")]
        public float Y { get; set; }

        [JsonProperty("z")]
        public float Z { get; set; }

        public Point32()
        {
            X = Y = Z = 0f;
        }

        public Point32(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
