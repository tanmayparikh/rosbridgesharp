using Newtonsoft.Json;
using Rosbridgenet.Messages.Std;

namespace Rosbridgenet.Messages.Sensor
{
    public class JointState : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "sensor_msgs/JointState";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("header")]
        public Header Header { get; set; }

        [JsonProperty("name")]
        public string[] Name { get; set; }

        [JsonProperty("position")]
        public double[] Position { get; set; }

        [JsonProperty("velocity")]
        public double[] Velocity { get; set; }

        [JsonProperty("effort")]
        public double[] Effort { get; set; }

        public JointState()
        {
            Header = new Header();
            Name = new string[0];
            Position = new double[0];
            Velocity = new double[0];
            Effort = new double[0];
        }

        public JointState(Header header, string[] name, double[] position, double[] velocity, double[] effort)
        {
            Name = name;
            Header = header;
            Position = position;
            Velocity = velocity;
            Effort = effort;
        }
    }
}
