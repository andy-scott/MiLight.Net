namespace MiLight.Net.Api
{
    using System;
    using MiLight.Net.Commands;

    public class White
    {
        [Obsolete("Please use the On method passing Zone.All")]
        public static byte[] AllOn()
        {
            return On(Zone.All);
        }

        [Obsolete("Please use the Off method passing Zone.All")]
        public static byte[] AllOff()
        {
            return Off(Zone.All);
        }

        public static byte[] BrightUp()
        {
            return new byte[] { 0x3c, 0x00, 0x55 };
        }

        public static byte[] BrightDown()
        {
            return new byte[] { 0x34, 0x00, 0x55 };
        }

        public static byte[] Warmer()
        {
            return new byte[] { 0x3E, 0x00, 0x55 };
        }

        public static byte[] Cooler()
        {
            return new byte[] { 0x3F, 0x00, 0x55 };
        }

        public static byte[] On(Zone zone)
        {
            byte value;
            switch (zone)
            {
                case Zone.All:
                    value = 0x35;
                    break;
                case Zone.One:
                    value = 0x38;
                    break;
                case Zone.Two:
                    value = 0x3D;
                    break;
                case Zone.Three:
                    value = 0x37;
                    break;
                case Zone.Four:
                    value = 0x32;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("zone");
            }

            return new byte[] { value, 0x00, 0x55 };
        }

        public static byte[] Off(Zone zone)
        {
            byte value;
            switch (zone)
            {
                case Zone.All:
                    value = 0x39;
                    break;
                case Zone.One:
                    value = 0x3B;
                    break;
                case Zone.Two:
                    value = 0x33;
                    break;
                case Zone.Three:
                    value = 0x3A;
                    break;
                case Zone.Four:
                    value = 0x36;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("zone");
            }

            return new byte[] { value, 0x00, 0x55 };
        }
    }
}
