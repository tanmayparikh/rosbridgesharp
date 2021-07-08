using Newtonsoft.Json;

namespace Rosbridgenet.Services.RosApi
{
    public class TopicsResponse : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "rosapi/Topics";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("topics")]
        public string[] Topics { get; set; }

        [JsonProperty("types")]
        public string[] Types { get; set; }

        public TopicsResponse()
        {
            Topics = new string[0];
            Types = new string[0];
        }

        public TopicsResponse(string[] topics, string[] types)
        {
            Topics = topics;
            Types = types;
        }
    }
}
