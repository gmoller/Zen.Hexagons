using System;

namespace Zen.Hexagons.ExtensionMethods
{
    public static class FloatExtensions
    {
        public static bool AboutEquals(this float value1, float value2)
        {
            var epsilon = Math.Max(Math.Abs(value1), Math.Abs(value2)) * 1E-15;

            return Math.Abs(value1 - value2) <= epsilon;
        }

        public static int Round(this float value)
        {
            return (int)Math.Round(value);
        }

        public static float Lerp(this float amount, float value1, float value2)
        {
            return value1 + (value2 - value1) * amount;
        }

        public static float ToRadians(this float value)
        {
            return (float)(Math.PI / 180 * value);
        }
    }
}