using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace rosbridgenet.Messages.Std
{
    public class Char : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/Char";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonIgnore]
        [JsonPropertyName("data")]
        public char Data { get; set; }

        public Char()
        {
            Data = '\0';
        }

        public Char(char data)
        {
            Data = data;
        }
    }
}
