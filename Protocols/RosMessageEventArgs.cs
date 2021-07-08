using System;
using System.Text;

namespace Rosbridgenet.Protocols
{
    public class RosMessageEventArgs : EventArgs
    {
        public byte[] Data { get; private set; }
        public string DataStr { get; private set; }

        public RosMessageEventArgs(byte[] data)
        {
            Data = data;
            DataStr = Encoding.Unicode.GetString(data);
        }

        public RosMessageEventArgs(string dataStr)
        {
            DataStr = dataStr;
            Data = Encoding.Unicode.GetBytes(dataStr);
        }
    }
}
