using System.Diagnostics;
using Zen.Hexagons.ExtensionMethods;

namespace Zen.Hexagons
{
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public readonly struct Point2F
    {
        #region State
        public float X { get; }
        public float Y { get; }
        #endregion

        public Point2F(float x, float y)
        {
            X = x;
            Y = y;
        }

        public static Point2F Empty => new Point2F(float.MinValue, float.MinValue);
        public static Point2F Zero => new Point2F(0.0f, 0.0f);

        #region Overrides and Overloads

        public override bool Equals(object obj)
        {
            return obj is Point2F point && this == point;
        }

        public static bool operator == (Point2F a, Point2F b)
        {
            return a.X.AboutEquals(b.X) && a.Y.AboutEquals(b.Y);
        }

        public static bool operator != (Point2F a, Point2F b)
        {
            return !(a == b);
        }

        public static Point2F operator + (Point2F a, Point2F b)
        {
            return new Point2F(a.X + b.X, a.Y + b.Y);
        }

        public static Point2F operator - (Point2F a, Point2F b)
        {
            return new Point2F(a.X - b.X, a.Y - b.Y);
        }

        public static Point2F operator * (Point2F a, Point2F b)
        {
            return new Point2F(a.X * b.X, a.Y * b.Y);
        }

        public static Point2F operator * (Point2F a, int scalar)
        {
            return new Point2F(a.X * scalar, a.Y * scalar);
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }

        public override string ToString()
        {
            return DebuggerDisplay;
        }

        private string DebuggerDisplay => $"{{X={X},Y={Y}}}";

        #endregion
    }
}