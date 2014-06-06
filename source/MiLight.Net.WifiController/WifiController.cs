﻿namespace MiLight.Net.WifiCintroller
{
    using System.Net;
    using System.Net.Sockets;

    public class WifiController
    {
        private readonly string ip;

        private readonly int port;

        public WifiController(string ip = "192.168.1.100", int port = 5000)
        {
            this.ip = ip;
            this.port = port;
        }

        public void Send(byte[] command)
        {
            var sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            var serverAddr = IPAddress.Parse(this.ip);

            var endPoint = new IPEndPoint(serverAddr, this.port);

            sock.SendTo(command, endPoint);
        }
    }
}