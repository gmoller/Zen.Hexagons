using System.Diagnostics;

namespace Zen.Hexagons
{
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public readonly struct HexAxial
    {
        public int Q { get; }
        public int R { get; }

        public HexAxial(int q, int r)
        {
            Q = q;
            R = r;
        }

        #region Overrides and Overloads

        public override bool Equals(object obj)
        {
            return obj is HexAxial axial && this == axial;
        }

        public static bool operator == (HexAxial a, HexAxial b)
        {
            return a.Q == b.Q && a.R == b.R;
        }

        public static bool operator != (HexAxial a, HexAxial b)
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