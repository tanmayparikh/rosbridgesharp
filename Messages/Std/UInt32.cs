using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace rosbridgenet.Messages.Std
{
    public class UInt32 : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/UInt32";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonIgnore]
        [JsonPropertyName("data")]
        public uint Data { get; set; }

        public UInt32()
        {
            Data = 0;
        }

        public UInt32(uint data)
        {
            Data = data;
        }
    }
}
