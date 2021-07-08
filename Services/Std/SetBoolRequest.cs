using Newtonsoft.Json;

namespace Rosbridgenet.Services.Std
{
    public class SetBoolRequest : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_srvs/SetBool";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("data")]
        public bool Data { get; set; }

        public SetBoolRequest()
        {
            Data = false;
        }
    }
}
