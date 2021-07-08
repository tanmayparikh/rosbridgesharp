using Newtonsoft.Json;
using Rosbridgenet.Messages.Std;

namespace Rosbridgenet.Messages.Geometry
{
    public class Vector3Stamped : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "geometry_msgs/Vector3Stamped";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }


        [JsonProperty("header")]
        public Header Header { get; set; }

        [JsonProperty("vector")]
        public Vector3 Vector { get; set; }

        public Vector3Stamped()
        {
            Header = new Header();
            Vector = new Vector3();
        }

        public Vector3Stamped(Header header, Vector3 vector3)
        {
            Header = header;
            Vector = vector3;
        }
    }
}
