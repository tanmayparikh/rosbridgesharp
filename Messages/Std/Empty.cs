using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace rosbridgenet.Messages.Std
{
    public class Empty : Message
    {
        [JsonIgnore]
        public const string ROSMessageType = "std_msgs/Empty";

        [JsonIgnore]
        public override string MessageType
        {
            get { return ROSMessageType; }
        }

        public Empty()
        {

        }
    }
}
