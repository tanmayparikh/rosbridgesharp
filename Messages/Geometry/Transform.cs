using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Geometry
{
    public class Transform : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "geometry_msgs/Transform";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("translation")]
        public Vector3 Translation { get; set; }

        [JsonProperty("rotation")]
        public Quaternion Rotation { get; set; }

        public Transform()
        {
            Translation = new Vector3();
            Rotation = new Quaternion();
        }

        public Transform(Vector3 translation, Quaternion rotation)
        {
            Translation = translation;
            Rotation = rotation;
        }
    }
}
