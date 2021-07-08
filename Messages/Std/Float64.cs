using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Std
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

        [JsonProperty("data")]
        public double Data { get; set; }

        public Float64()
        {
            Data = 0d;
        }

        public Float64(double data)
        {
            Data = data;
        }
    }
}
