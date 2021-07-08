using Newtonsoft.Json;

namespace Rosbridgenet.Messages.Std
{
    public class Header : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/Header";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonProperty("seq")]
        public uint SequenceId { get; set; }

        [JsonProperty("stamp")]
        public Time Stamp { get; set; }

        [JsonProperty("frame_id")]
        public string FrameId { get; set; }

        public Header()
        {
            SequenceId = 0;
            Stamp = new Time();
            FrameId = string.Empty;
        }

        public Header(uint sequenceId, Time stamp, string frameId)
        {
            SequenceId = sequenceId;
            Stamp = stamp;
            FrameId = frameId;
        }
    }
}
