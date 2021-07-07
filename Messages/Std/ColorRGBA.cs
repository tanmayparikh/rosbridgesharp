using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace rosbridgenet.Messages.Std
{
    public class ColorRGBA : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/ColorRGBA";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonIgnore]
        [JsonPropertyName("r")]
        public float R { get; set; }

        [JsonIgnore]
        [JsonPropertyName("g")]
        public float G { get; set; }

        [JsonIgnore]
        [JsonPropertyName("b")]
        public float B { get; set; }

        [JsonIgnore]
        [JsonPropertyName("a")]
        public float A { get; set; }

        public ColorRGBA()
        {
            R = 0f;
            G = 0f;
            B = 0f;
            A = 0f;
        }

        public ColorRGBA(float r, float g, float b, float a)
        {
            R = r;
            G = g;
            B = b;
            A = a;
        }
    }
}
