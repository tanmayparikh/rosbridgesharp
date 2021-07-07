using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace rosbridgenet.Messages.Std
{
    public class UInt64 : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/UInt64";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonIgnore]
        [JsonPropertyName("data")]
        public ulong Data { get; set; }

        public UInt64()
        {
            Data = 0;
        }

        public UInt64(ulong data)
        {
            Data = data;
        }
    }
}
