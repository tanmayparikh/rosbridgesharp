using Newtonsoft.Json;

namespace Rosbridgenet.Services.Std
{
    public class SetBoolResponse : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_srvs/SetBool";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        public SetBoolResponse()
        {
            Success = false;
            Message = string.Empty;
        }

        public SetBoolResponse(bool success, string message)
        {
            Success = success;
            Message = message;
        }
    }
}
