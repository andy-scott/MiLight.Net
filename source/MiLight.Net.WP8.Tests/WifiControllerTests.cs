namespace MiLight.Net.WP8.Tests
{
    using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

    using MiLight.Net.Api;
    using MiLight.Net.WP8.WifiController;

    using MiLight.Net.Commands;
   
    [TestClass]
    public class WifiControllerTests
    {
        [TestMethod]
        public void CanTurnWhiteLightsOff()
        {
            var controller = new WifiController("192.168.0.6");

            controller.Send(White.Off(Zone.All));
        }

        [TestMethod]
        public void CanTurnWhiteLightsOn()
        {
            var controller = new WifiController("192.168.0.6");

            controller.Send(White.On(Zone.All));
        }
    }
}