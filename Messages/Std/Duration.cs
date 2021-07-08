using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Std
{
    public class Duration : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/Duration";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("secs")]
        public uint Secs { get; set; }

        [JsonProperty("nsecs")]
        public uint NSecs { get; set; }

        public Duration()
        {
            Secs = 0;
            NSecs = 0;
        }

        public Duration(uint secs, uint nsecs)
        {
            Secs = secs;
            NSecs = nsecs;
        }
    }
}
