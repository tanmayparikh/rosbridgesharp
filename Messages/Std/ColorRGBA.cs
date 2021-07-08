using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Std
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

        [JsonProperty("r")]
        public float R { get; set; }

        [JsonProperty("g")]
        public float G { get; set; }

        [JsonProperty("b")]
        public float B { get; set; }

        [JsonProperty("a")]
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
