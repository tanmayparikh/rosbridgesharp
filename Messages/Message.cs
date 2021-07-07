using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rosbridgenet.Messages
{
    public abstract class Message
    {
        public abstract string MessageType { get; }
    }
}