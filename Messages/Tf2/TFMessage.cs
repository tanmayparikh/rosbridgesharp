using Newtonsoft.Json;
using Rosbridgenet.Messages.Geometry;

namespace Rosbridgenet.Messages.Tf2
{
    public class TFMessage : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "tf2_msgs/TFMessage";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("transforms")]
        public TransformStamped[] Transforms { get; set; }

        public TFMessage()
        {
            Transforms = new TransformStamped[0];
        }

        public TFMessage(TransformStamped[] transforms)
        {
            Transforms = transforms;
        }
    }
}
