using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Std
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

        [JsonProperty("data")]
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
