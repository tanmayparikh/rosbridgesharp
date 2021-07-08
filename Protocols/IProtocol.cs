using System;

namespace Rosbridgenet.Protocols
{
    public interface IProtocol
    {
        void Connect();
        void Disconnect();
        bool IsAlive();
        void Send(byte[] data);
        void Send(string data);

        event EventHandler<RosMessageEventArgs> OnReceive;
        event EventHandler OnConnected;
        event EventHandler OnClosed;
    }
}
