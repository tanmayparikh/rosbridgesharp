using Newtonsoft.Json;

namespace Rosbridgenet.Services.Std
{
    public class TriggerRequest : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_srvs/Trigger";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        public TriggerRequest()
        {
        }
    }
}
