using Newtonsoft.Json;

namespace Rosbridgenet.Services.Std
{
    public class TriggerResponse : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_srvs/Trigger";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        public TriggerResponse()
        {
            Success = false;
            Message = string.Empty;
        }

        public TriggerResponse(bool success, string message)
        {
            Success = success;
            Message = message;
        }
    }
}
