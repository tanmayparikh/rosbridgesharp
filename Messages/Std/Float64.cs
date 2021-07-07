using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace rosbridgenet.Messages.Std
{
    public class Float64 : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/Float64";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonIgnore]
        [JsonPropertyName("data")]
        public double Data { get; set; }

        public Float64()
        {
            Data = 0f;
        }

        public Float64(double data)
        {
            Data = data;
        }
    }
}
