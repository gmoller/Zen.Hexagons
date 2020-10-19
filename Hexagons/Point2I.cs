using System.Diagnostics;

namespace Zen.Hexagons
{
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public readonly struct Point2I
    {
        #region State
        public int X { get; }
        public int Y { get; }
        #endregion

        public Point2I(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Point2I Empty => new Point2I(int.MinValue, int.MinValue);
        public static Point2I Zero => new Point2I(0, 0);

        #region Overrides and Overloads

        public override bool Equals(object obj)
        {
            return obj is Point2I point && this == point;
        }

        public static bool operator == (Point2I a, Point2I b)
        {
            return a.X == b.X && a.Y == b.Y;
        }

        public static bool operator != (Point2I a, Point2I b)
        {
            return !(a == b);
        }

        public static Point2I operator + (Point2I a, Point2I b)
        {
            return new Point2I(a.X + b.X, a.Y + b.Y);
        }

        public static Point2I operator - (Point2I a, Point2I b)
        {
            return new Point2I(a.X - b.X, a.Y - b.Y);
        }

        public static Point2I operator * (Point2I a, Point2I b)
        {
            return new Point2I(a.X * b.X, a.Y * b.Y);
        }

        public static Point2I operator * (Point2I a, int scalar)
        {
            return new Point2I(a.X * scalar, a.Y * scalar);
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