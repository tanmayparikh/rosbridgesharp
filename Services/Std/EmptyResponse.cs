using Newtonsoft.Json;

namespace Rosbridgenet.Services.Std
{
    public class EmptyResponse : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_srvs/Empty";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        public EmptyResponse()
        {
        }
    }
}
