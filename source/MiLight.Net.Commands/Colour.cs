namespace MiLight.Net.Api
{
    using System;
    using MiLight.Net.Commands;

    public static class Colour
    {
        public static byte[] AllOff()
        {
            return new byte[] { 0x41, 0x00, 0x55 };
        }

        public static byte[] AllOn()
        {
            return new byte[] { 0x42, 0x00, 0x55 };
        }

        public static byte[] On(Zone zone)
        {
            byte value;
            switch (zone)
            {
                case Zone.One:
                    value = 0x45;
                    break;
                case Zone.Two:
                    value = 0x47;
                    break;
                case Zone.Three:
                    value = 0x49;
                    break;
                case Zone.Four:
                    value = 0x4B;
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
                case Zone.One:
                    value = 0x46;
                    break;
                case Zone.Two:
                    value = 0x48;
                    break;
                case Zone.Three:
                    value = 0x4A;
                    break;
                case Zone.Four:
                    value = 0x4C;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("zone");
            }

            return new byte[] { value, 0x00, 0x55 };
        }

        public static byte[] Hue(decimal colourCode)
        {
            var hexColourCode = decimal.ToByte(16);
            return new byte[] { 0x20, hexColourCode, 0x55 };
        }

        /// <summary>
        /// Set the brightness level of teh coloured lights
        /// </summary>
        /// <param name="level">Accepted values 2 - 27, 2 being low, 27 being high.  
        /// Values lower than 2 are coerced to 2, values higher than 27 are coerced to 27</param>
        /// <returns>Byte command</returns>
        public static byte[] SetBrightness(int level)
        {
            if (level < 2)
            { 
                level = 2; }
            else if (level > 27)
            {
                level = 27;
            }

            return new byte[] { 0x4E, Convert.ToByte(level.ToString("X"), 16), 0x55 };
        }

        [Obsolete("Please use SetBrightness(27) instead")]
        public static byte[] BrightUp()
        {
            return SetBrightness(27);
        }

        [Obsolete("Please use SetBrightness(2) instead")]
        public static byte[] BrightDown()
        {
            return SetBrightness(2);
        }

        public static byte[] SpeedUp()
        {
            return new byte[] { 0x25, 0x0, 0x55 };
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