using Newtonsoft.Json;

namespace Rosbridgenet.Services.Std
{
    public class EmptyRequest : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_srvs/Empty";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        public EmptyRequest()
        {
        }
    }
}
