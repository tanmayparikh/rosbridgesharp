using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Std
{
    public class Bool : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/Bool";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("data")]
        public bool Data { get; set; }

        public Bool()
        {
            Data = false;
        }

        public Bool(bool data)
        {
            Data = data;
        }
    }
}