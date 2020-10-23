using System.Diagnostics;

namespace Zen.Hexagons
{
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public readonly struct HexAxialCoordinates
    {
        public int Q { get; }
        public int R { get; }

        public HexAxialCoordinates(int q, int r)
        {
            Q = q;
            R = r;
        }

        #region Overrides and Overloads

        public override bool Equals(object obj)
        {
            return obj is HexAxialCoordinates axial && this == axial;
        }

        public static bool operator == (HexAxialCoordinates a, HexAxialCoordinates b)
        {
            return a.Q == b.Q && a.R == b.R;
        }

        public static bool operator != (HexAxialCoordinates a, HexAxialCoordinates b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return Q.GetHashCode() ^ R.GetHashCode();
        }

        public override string ToString()
        {
            return DebuggerDisplay;
        }

        private string DebuggerDisplay => $"{{Q={Q},R={R}}}";

        #endregion
    }
}