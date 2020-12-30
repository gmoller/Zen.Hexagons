using System;

namespace Zen.Hexagons
{
    public class HexPointyTopped : Hex
    {
        private static readonly HexCubeCoordinates[] Directions =
        {
            new HexCubeCoordinates( 0,  0,  0), // north
            new HexCubeCoordinates(+1,  0, -1), // northeast
            new HexCubeCoordinates(+1, -1,  0), // east
            new HexCubeCoordinates( 0, -1, +1), // southeast
            new HexCubeCoordinates( 0,  0,  0), // south
            new HexCubeCoordinates(-1,  0, +1), // southwest
            new HexCubeCoordinates(-1, +1,  0), // west
            new HexCubeCoordinates( 0, +1, -1), // northwest
        };

        public HexPointyTopped(OffsetCoordinatesType offsetCoordinatesType, float hexSize, bool align00With00) : base(HexType.PointyTopped, offsetCoordinatesType, hexSize, align00With00)
        {
        }


        protected override HexCubeCoordinates GetNeighboringCube(Direction direction)
        {
            var neighboringCube = Directions[(int)direction];

            return neighboringCube;
        }


        public override HexCubeCoordinates OffsetToCubeCoordinates(HexOffsetCoordinates offset)
        {
            var col = offset.Col;
            var row = offset.Row;

            col -= OffsetCoordinatesType switch
            {
                OffsetCoordinatesType.Even => (row + (row & 1)) / 2,
                OffsetCoordinatesType.Odd => (row - (row & 1)) / 2,
                _ => throw new ArgumentOutOfRangeException(nameof(OffsetCoordinatesType), OffsetCoordinatesType, $"OffsetCoordinatesType {OffsetCoordinatesType} is not supported.")
            };
            var y = -col - row;
            var cube = new HexCubeCoordinates(col, y, row);

            return cube;
        }

        public override HexOffsetCoordinates CubeToOffsetCoordinates(HexCubeCoordinates cube)
        {
            var col = cube.X;
            var row = cube.Z;

            col += OffsetCoordinatesType switch
            {
                OffsetCoordinatesType.Even => (row + (row & 1)) / 2,
                OffsetCoordinatesType.Odd => (row - (row & 1)) / 2,
                _ => throw new ArgumentOutOfRangeException(nameof(OffsetCoordinatesType), OffsetCoordinatesType, $"OffsetCoordinatesType {OffsetCoordinatesType} is not supported.")
            };

            var offsetCoordinates = new HexOffsetCoordinates(col, row);

            return offsetCoordinates;
        }

        public override Point2F FromOffsetCoordinatesToPixel(HexOffsetCoordinates offset)
        {
            var x = Size;
            var y = Size * (1.5f * offset.Row);

            x *= OffsetCoordinatesType switch
            {
                OffsetCoordinatesType.Even => (float)(Constants.SquareRootOf3 * (offset.Col - 0.5f * (offset.Row & 1))),
                OffsetCoordinatesType.Odd => (float)(Constants.SquareRootOf3 * (offset.Col + 0.5f * (offset.Row & 1))),
                _ => throw new ArgumentOutOfRangeException(nameof(OffsetCoordinatesType), OffsetCoordinatesType, $"OffsetCoordinatesType {OffsetCoordinatesType} is not supported.")
            };

            var pixel = new Point2F(x, y) + Offset;

            return pixel;
        }

        public override HexAxialCoordinates FromPixelToAxialCoordinates(int x, int y)
        {
            var q = (float)((Constants.OneThirdOfSquareRootOf3 * x - Constants.OneThird * y) / Size);
            var r = (float)(Constants.TwoThirds * y / Size);
            var axial = RoundAxialCoordinates(q, r);

            return axial;
        }

        public override Point2F FromAxialCoordinatesToPixel(HexAxialCoordinates axial)
        {
            var x = (float)(Size * (Constants.SquareRootOf3 * axial.Q + Constants.HalfOfSquareRootOf3 * axial.R));
            var y = Size * (1.5f * axial.R);
            var pixel = new Point2F(x, y);

            return pixel;
        }

        public override HexCubeCoordinatesSextuple GetAllNeighbors(HexCubeCoordinates cube)
        {
            var neighbors = new HexCubeCoordinatesSextuple();

            var neighboringCube = GetNeighbor(cube, Direction.NorthEast);
            neighbors.HexCubeCoordinates0 = neighboringCube;

            neighboringCube = GetNeighbor(cube, Direction.East);
            neighbors.HexCubeCoordinates1 = neighboringCube;

            neighboringCube = GetNeighbor(cube, Direction.SouthEast);
            neighbors.HexCubeCoordinates2 = neighboringCube;

            neighboringCube = GetNeighbor(cube, Direction.SouthWest);
            neighbors.HexCubeCoordinates3 = neighboringCube;

            neighboringCube = GetNeighbor(cube, Direction.West);
            neighbors.HexCubeCoordinates4 = neighboringCube;

            neighboringCube = GetNeighbor(cube, Direction.NorthWest);
            neighbors.HexCubeCoordinates5 = neighboringCube;

            return neighbors;
        }

        public override Point2FSextuple GetCorners()
        {
            var corners = new Point2FSextuple
            {
                Point0 = GetCorner(0.0f, -1.0f, Size), // North
                Point1 = GetCorner(0.86602540378f, -0.5f, Size), // NorthEast
                Point2 = GetCorner(0.86602540378f, 0.5f, Size), // SouthEast
                Point3 = GetCorner(0.0f, 1.0f, Size), // South
                Point4 = GetCorner(-0.86602540378f, 0.5f, Size), // SouthWest
                Point5 = GetCorner(-0.86602540378f, -0.5f, Size) // NorthWest
            };

            return corners;
        }

        protected override float GetWidth()
        {
            return SideToSide;
        }

        protected override float GetHeight()
        {
            return VertexToVertex;
        }

        protected override Point2F DetermineOffset()
        {
            switch (OffsetCoordinatesType)
            {
                case OffsetCoordinatesType.Odd:
                    return new Point2F(Apothem, Size);
                case OffsetCoordinatesType.Even:
                    return new Point2F(SideToSide, Size);
                default:
                    throw new ArgumentOutOfRangeException(nameof(OffsetCoordinatesType), OffsetCoordinatesType, $"OffsetCoordinatesType {OffsetCoordinatesType} is not supported.");
            }
        }

        public override int GetWorldWidthInPixels(int worldMapColumns)
        {
            // assumes even
            var worldWidthInPixels = worldMapColumns * SideToSide + Apothem;

            return (int)worldWidthInPixels;
        }

        public override int GetWorldHeightInPixels(int worldMapRows)
        {
            // assumes even
            var worldHeightInPixels = worldMapRows * Constants.OneHalf * VertexToVertex + worldMapRows * Constants.OneHalf * SideLength + VertexToVertex * Constants.OneQuarter;

            return (int)worldHeightInPixels;
        }

        protected override Direction[] GetRingDirections()
        {
            var directions = new [] { Direction.NorthWest, Direction.NorthEast, Direction.East, Direction.SouthEast, Direction.SouthWest, Direction.West };

            return directions;
        }
    }
}