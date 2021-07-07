using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace rosbridgenet.Messages.Std
{
    public class Bool : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/Bool";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        [JsonInclude]
        [JsonPropertyName("data")]
        public bool Data { get; set; }

        public Bool()
        {
            Data = false;
        }

        public Bool(bool data)
        {
            Data = data;
        }
    }
}