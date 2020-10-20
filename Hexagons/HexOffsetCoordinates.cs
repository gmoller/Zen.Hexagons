using System.Diagnostics;

namespace Zen.Hexagons
{
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public readonly struct HexOffsetCoordinates
    {
        public int Col { get; }
        public int Row { get; }

        public HexOffsetCoordinates(int col, int row)
        {
            Col = col;
            Row = row;
        }

        #region Overrides and Overloads

        public override bool Equals(object obj)
        {
            return obj is HexOffsetCoordinates offsetCoordinates && this == offsetCoordinates;
        }

        public static bool operator == (HexOffsetCoordinates a, HexOffsetCoordinates b)
        {
            return a.Col == b.Col && a.Row == b.Row;
        }

        public static bool operator != (HexOffsetCoordinates a, HexOffsetCoordinates b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return Col.GetHashCode() ^ Row.GetHashCode();
        }

        public override string ToString()
        {
            return DebuggerDisplay;
        }

        private string DebuggerDisplay => $"{{Col={Col},Row={Row}}}";

        #endregion
    }
}