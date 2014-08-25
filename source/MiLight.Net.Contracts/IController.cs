namespace MiLight.Net.Contracts
{
    public interface IController
    {
        void Send(byte[] command);
    }
}