using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace rosbridgenet.Messages.Std
{
    public class UInt8 : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/UInt8";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonIgnore]
        [JsonPropertyName("data")]
        public byte Data { get; set; }

        public UInt8()
        {
            Data = 0;
        }

        public UInt8(byte data)
        {
            Data = data;
        }
    }
}
