using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Std
{
    public class Empty : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/Empty";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        public Empty()
        {

        }
    }
}
