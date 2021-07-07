using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace rosbridgenet.Messages.Std
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

        [JsonIgnore]
        [JsonPropertyName("secs")]
        public uint Secs { get; set; }

        [JsonIgnore]
        [JsonPropertyName("nsecs")]
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
