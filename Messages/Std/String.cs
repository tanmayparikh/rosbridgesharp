using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace rosbridgenet.Messages.Std
{
    public class String : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/String";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonIgnore]
        [JsonPropertyName("data")]
        public string Data { get; set; }

        public String()
        {
            Data = string.Empty;
        }

        public String(string data)
        {
            Data = data;
        }
    }
}
