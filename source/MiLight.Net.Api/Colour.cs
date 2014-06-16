namespace MiLight.Net.Api
{
    public static class Colour
    {
        public static byte[] Off()
        {
            return new byte[] { 0x46, 0x00, 0x55 };
        }

        public static byte[] On()
        {
            return new byte[] { 0x45, 0x00, 0x55 };
        }

        public static byte[] Hue(decimal colourCode)
        {
            var hexColourCode = decimal.ToByte(16);
            return new byte[] { 0x20, hexColourCode, 0x55 };
        }

        public static byte[] BrightUp()
        {
            return new byte[] { 0x23, 0x00, 0x55 };
        }

        public static byte[] BrightDown()
        {
            return new byte[] { 0x24, 0x00, 0x55 };
        }

        public static byte[] SpeedUp()
        {
            return new byte[] { 0x25, 0x00, 0x55 };
        }

        public static byte[] SpeedDown()
        {
            return new byte[] { 0x26, 0x00, 0x55 };
        }

        public static byte[] EffectUp()
        {
            return new byte[] { 0x27, 0x00, 0x55 };
        }

        public static byte[] EffectDown()
        {
            return new byte[] { 0x28, 0x00, 0x55 };
        }
    }
}