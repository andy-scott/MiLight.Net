namespace MiLight.Net.Tests
{
    using MiLight.Net.Commands;
    using MiLight.Net.Api;
    using MiLight.Net.WifiCintroller;

    using Xunit;

    public class WifiControllerTests
    {
        [Fact]
        public void CanSwitchWhiteLightsOnForZoneOne()
        {
            var controller = new WifiController("192.168.0.6");

            controller.Send(White.On(Zone.One));
        }

        [Fact]
        public void CanSwitchWhiteLightsOffForZoneOne()
        {
            var controller = new WifiController("192.168.0.6");

            controller.Send(White.Off(Zone.One));
        }

        [Fact]
        public void CanSwitchWhiteLightsOnForAllZones()
        {
            var controller = new WifiController("192.168.0.6");

            controller.Send(White.AllOn());
        }

        [Fact]
        public void CanSwitchWhiteLightsOffForAllZones()
        {
            var controller = new WifiController("192.168.0.6");

            controller.Send(White.AllOff());
        }

        [Fact]
        public void CanSwitchColorLightsOn()
        {
            var controller = new WifiController("192.168.0.6");

            controller.Send(Colour.AllOn());
        }

        [Fact]
        public void CanSwitchColorLightsOff()
        {
            var controller = new WifiController("192.168.0.6");

            controller.Send(Colour.AllOff());
        }

        [Fact]
        public void CanSwitchColorLightsOnZoneOne()
        {
            var controller = new WifiController("192.168.0.6");

            controller.Send(Colour.On(Zone.One));
        }

        [Fact]
        public void CanSwitchColorLightsOffZoneOne()
        {
            var controller = new WifiController("192.168.0.6");

            controller.Send(Colour.Off(Zone.One));
        }

        [Fact]
        public void CanSetBrightnessLevelTo27()
        {
            var controller = new WifiController("192.168.0.6");

            controller.Send(Colour.SetBrightness(27));
        }

        [Fact]
        public void CanSetBrightnessLevelTo2()
        {
            var controller = new WifiController("192.168.0.6");

            controller.Send(Colour.SetBrightness(2));
        }

        [Fact]
        public void CanSetBrightnessLevelTo10()
        {
            var controller = new WifiController("192.168.0.6");

            controller.Send(Colour.SetBrightness(10));
        }

        [Fact]
        public void CanSetLightsToRoyalBlue()
        {
            var controller = new WifiController("192.168.0.6");

            controller.Send(Colour.Hue(10));
        }

        [Fact]
        public void CanSetLightsToCycleAllColours()
        {
            var controller = new WifiController("192.168.0.6");

            for (var colourCode = 1; colourCode <= 255; colourCode++)
            {
                controller.Send(Colour.Hue(colourCode));
            }
                
        }

        [Fact]
        public void CanSetAllColorLightsToWhite()
        {
            var controller = new WifiController("192.168.0.6");

            controller.Send(Colour.SetWhite(Zone.All));
        }

        [Fact]
        public void CanSetZoneOneColorLightsToWhite()
        {
            var controller = new WifiController("192.168.0.6");

            controller.Send(Colour.SetWhite(Zone.One));
        }

        [Fact]
        public void CanSwitchAllLightsOff()
        {
            var controller = new WifiController("192.168.0.6");

            controller.Send(White.Off(Zone.All));
 
            controller.Send(Colour.Off(Zone.All));
        }
    }
}