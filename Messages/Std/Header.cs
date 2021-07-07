using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace rosbridgenet.Messages.Std
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

        [JsonInclude]
        [JsonPropertyName("seq")]
        public uint SequenceId { get; set; }

        [JsonInclude]
        [JsonPropertyName("stamp")]
        public Time Stamp { get; set; }

        [JsonInclude]
        [JsonPropertyName("frame_id")]
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
