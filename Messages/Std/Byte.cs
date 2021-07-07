using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace rosbridgenet.Messages.Std
{
    public class Byte : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/Byte";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonInclude]
        [JsonPropertyName("data")]
        public byte Data { get; set; }

        public Byte()
        {
            Data = 0;
        }

        public Byte(byte data)
        {
            Data = data;
        }
    }
}