namespace MiLight.Net.WifiCintroller
{
    using System.Net;
    using System.Net.Sockets;

    using MiLight.Net.Contracts;

    public class WifiController : IController
    {
        private readonly string ip;

        private readonly int port;

        public WifiController(string ip = "192.168.1.100", int port = 8899)
        {
            this.ip = ip;
            this.port = port;
        }

        /// <summary>
        /// Sends the command to the wifi controller, also has a 100 millisecond delay to ensure commands are not lost
        /// </summary>
        /// <param name="command">The command to control the lights</param>
        public void Send(byte[] command)
        {
            var sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            var serverAddr = IPAddress.Parse(this.ip);

            var endPoint = new IPEndPoint(serverAddr, this.port);

            sock.SendTo(command, endPoint);

            System.Threading.Thread.Sleep(100);
        }
    }
}