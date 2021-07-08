using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Std
{
    public class Time : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/Time";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("secs")]
        public uint Secs { get; set; }

        [JsonProperty("nsecs")]
        public uint NSecs { get; set; }

        public Time()
        {
            Secs = 0;
            NSecs = 0;
        }

        public Time(uint secs, uint nsecs)
        {
            Secs = secs;
            NSecs = nsecs;
        }
    }
}
