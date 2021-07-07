using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace rosbridgenet.Messages.Std
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

        [JsonIgnore]
        [JsonPropertyName("secs")]
        public uint Secs { get; set; }

        [JsonIgnore]
        [JsonPropertyName("nsecs")]
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
