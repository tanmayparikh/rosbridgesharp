using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace rosbridgenet.Messages.Std
{
    public class Int64 : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/Int64";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonIgnore]
        [JsonPropertyName("data")]
        public long Data { get; set; }

        public Int64()
        {
            Data = 0;
        }

        public Int64(long data)
        {
            Data = data;
        }
    }
}
