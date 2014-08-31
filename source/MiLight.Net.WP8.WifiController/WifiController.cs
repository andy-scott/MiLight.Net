namespace MiLight.Net.WP8.WifiController
{
    using System;
    using System.Threading.Tasks;

    using Windows.Networking.Sockets;

    using Windows.Networking;
    using Windows.Storage.Streams;

    using MiLight.Net.Contracts;

    public class WifiController : IController
    {
        private readonly HostName hostName;

        private readonly string port;

        public WifiController(string ip = "192.168.1.100", int port = 8899)
        {
            this.hostName = new HostName(ip);
            this.port = port.ToString();
        }

        public async Task Send(byte[] command)
        {
            using (var socket = new DatagramSocket())
            {
                using (var stream = await socket.GetOutputStreamAsync(this.hostName, this.port))
                {
                    using (var dataWriter = new DataWriter(stream))
                    {
                        dataWriter.WriteBytes(command);
                        await dataWriter.StoreAsync();
                        dataWriter.DetachStream();
                    }
                }
            }
        }
    }
}