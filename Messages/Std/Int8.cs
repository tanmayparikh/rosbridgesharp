using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace rosbridgenet.Messages.Std
{
    public class Int8 : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/Int8";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonIgnore]
        [JsonPropertyName("data")]
        public sbyte Data { get; set; }

        public Int8()
        {
            Data = 0;
        }

        public Int8(sbyte data)
        {
            Data = data;
        }
    }
}
