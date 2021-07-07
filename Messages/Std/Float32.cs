using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace rosbridgenet.Messages.Std
{
    public class Float32 : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/Float32";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonIgnore]
        [JsonPropertyName("data")]
        public float Data { get; set; }

        public Float32()
        {
            Data = 0f;
        }

        public Float32(float data)
        {
            Data = data;
        }
    }
}
