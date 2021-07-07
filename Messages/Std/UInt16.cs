using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace rosbridgenet.Messages.Std
{
    public class UInt16 : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/UInt16";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonIgnore]
        [JsonPropertyName("data")]
        public ushort Data { get; set; }

        public UInt16()
        {
            Data = 0;
        }

        public UInt16(ushort data)
        {
            Data = data;
        }
    }
}
