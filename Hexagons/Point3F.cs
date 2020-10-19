using System.Diagnostics;
using Zen.Hexagons.ExtensionMethods;

namespace Zen.Hexagons
{
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public readonly struct Point3F
    {
        #region State
        public float X { get; }
        public float Y { get; }
        public float Z { get; }
        #endregion

        public Point3F(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Point3F Empty => new Point3F(float.MinValue, float.MinValue, float.MinValue);
        public static Point3F Zero => new Point3F(0.0f, 0.0f, 0.0f);

        #region Overrides and Overloads

        public override bool Equals(object obj)
        {
            return obj is Point3F point && this == point;
        }

        public static bool operator == (Point3F a, Point3F b)
        {
            return a.X.AboutEquals(b.X) && a.Y.AboutEquals(b.Y) && a.Z.AboutEquals(b.Z);
        }

        public static bool operator != (Point3F a, Point3F b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
        }

        public override string ToString()
        {
            return DebuggerDisplay;
        }

        private string DebuggerDisplay => $"{{X={X},Y={Y},Z={Z}}}";

        #endregion
    }
}