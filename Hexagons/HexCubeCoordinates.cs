using System.Diagnostics;

namespace Zen.Hexagons
{
    [DebuggerDisplay("{" + nameof(DebuggerDisplay) + ",nq}")]
    public readonly struct HexCubeCoordinates
    {
        public int X { get; }
        public int Y { get; }
        public int Z { get; }

        public HexCubeCoordinates(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static HexCubeCoordinates operator + (HexCubeCoordinates a, HexCubeCoordinates b)
        {
            var hexCube = new HexCubeCoordinates(a.X + b.X, a.Y + b.Y, a.Z + b.Z);

            return hexCube;
        }

        public static HexCubeCoordinates operator * (HexCubeCoordinates a, int k)
        {
            var hexCube = a.Scale(k);

            return hexCube;
        }

        public HexCubeCoordinates Scale(int k)
        {
            var scaledCube = new HexCubeCoordinates(X * k, Y * k, Z * k);

            return scaledCube;
        }

        #region Overrides and Overloads

        public override bool Equals(object obj)
        {
            return obj is HexCubeCoordinates cube && this == cube;
        }

        public static bool operator == (HexCubeCoordinates a, HexCubeCoordinates b)
        {
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        }

        public static bool operator != (HexCubeCoordinates a, HexCubeCoordinates b)
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