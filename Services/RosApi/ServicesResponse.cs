using Newtonsoft.Json;

namespace Rosbridgenet.Services.RosApi
{
    public class ServicesResponse : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "rosapi/Services";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("services")]
        public string[] Services { get; set; }

        public ServicesResponse()
        {
            Services = new string[0];
        }

        public ServicesResponse(string[] services)
        {
            Services = services;
        }
    }
}
