using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace rosbridgenet.Messages.Std
{
    public class Int32 : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/Int32";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonIgnore]
        [JsonPropertyName("data")]
        public int Data { get; set; }

        public Int32()
        {
            Data = 0;
        }

        public Int32(int data)
        {
            Data = data;
        }
    }
}
