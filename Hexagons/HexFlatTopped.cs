using System;

namespace Zen.Hexagons
{
    public class HexFlatTopped : Hex
    {
        private static readonly HexCubeCoordinates[] Directions =
        {
            new HexCubeCoordinates( 0, +1, -1), // north
            new HexCubeCoordinates(+1,  0, -1), // northeast
            new HexCubeCoordinates( 0,  0,  0), // east
            new HexCubeCoordinates(+1, -1,  0), // southeast
            new HexCubeCoordinates( 0, -1, +1), // south
            new HexCubeCoordinates(-1,  0, +1), // southwest
            new HexCubeCoordinates( 0,  0,  0), // west
            new HexCubeCoordinates(-1, +1,  0), // northwest
        };

        public HexFlatTopped(OffsetCoordinatesType offsetCoordinatesType, float hexSize, bool align00With00) : base(HexType.FlatTopped, offsetCoordinatesType, hexSize, align00With00)
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

            row -= OffsetCoordinatesType switch
            {
                OffsetCoordinatesType.Even => (col + (col & 1)) / 2,
                OffsetCoordinatesType.Odd => (col - (col & 1)) / 2,
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

            row += OffsetCoordinatesType switch
            {
                OffsetCoordinatesType.Even => (col + (col & 1)) / 2,
                OffsetCoordinatesType.Odd => (col - (col & 1)) / 2,
                _ => throw new ArgumentOutOfRangeException(nameof(OffsetCoordinatesType), OffsetCoordinatesType, $"OffsetCoordinatesType {OffsetCoordinatesType} is not supported.")
            };

            var offsetCoordinates = new HexOffsetCoordinates(col, row);

            return offsetCoordinates;
        }

        public override Point2F FromOffsetCoordinatesToPixel(HexOffsetCoordinates offset)
        {
            var x = Size * (1.5f * offset.Col);
            var y = Size;

            y *= OffsetCoordinatesType switch
            {
                OffsetCoordinatesType.Even => (float)(Constants.SquareRootOf3 * (offset.Row - 0.5f * (offset.Col & 1))),
                OffsetCoordinatesType.Odd => (float)(Constants.SquareRootOf3 * (offset.Row + 0.5f * (offset.Col & 1))),
                _ => throw new ArgumentOutOfRangeException(nameof(OffsetCoordinatesType), OffsetCoordinatesType, $"OffsetCoordinatesType {OffsetCoordinatesType} is not supported.")
            };

            var pixel = new Point2F(x, y) + Offset;

            return pixel;
        }

        public override HexAxialCoordinates FromPixelToAxialCoordinates(int x, int y)
        {
            var q = (float)(Constants.TwoThirds * x / Size);
            var r = (float)((-Constants.OneThird * x + Constants.OneThirdOfSquareRootOf3 * y) / Size);
            var axial = RoundAxialCoordinates(q, r);

            return axial;
        }

        public override Point2F FromAxialCoordinatesToPixel(HexAxialCoordinates axial)
        {
            var x = Size * (1.5f * axial.Q);
            var y = (float)(Size * (Constants.HalfOfSquareRootOf3 * axial.Q + Constants.SquareRootOf3 * axial.R));
            var pixel = new Point2F(x, y);

            return pixel;
        }

        public override HexCubeCoordinatesSextuple GetAllNeighbors(HexCubeCoordinates cube)
        {
            var neighbors = new HexCubeCoordinatesSextuple();

            var neighboringCube = GetNeighbor(cube, Direction.North);
            neighbors.HexCubeCoordinates0 = neighboringCube;

            neighboringCube = GetNeighbor(cube, Direction.NorthEast);
            neighbors.HexCubeCoordinates1 = neighboringCube;

            neighboringCube = GetNeighbor(cube, Direction.SouthEast);
            neighbors.HexCubeCoordinates2 = neighboringCube;

            neighboringCube = GetNeighbor(cube, Direction.South);
            neighbors.HexCubeCoordinates3 = neighboringCube;

            neighboringCube = GetNeighbor(cube, Direction.SouthWest);
            neighbors.HexCubeCoordinates4 = neighboringCube;

            neighboringCube = GetNeighbor(cube, Direction.NorthWest);
            neighbors.HexCubeCoordinates5 = neighboringCube;

            return neighbors;
        }

        public override Point2FSextuple GetCorners()
        {
            var corners = new Point2FSextuple
            {
                Point0 = GetCorner(0.5f, -0.86602540378f, Size), // NorthEast
                Point1 = GetCorner(1.0f, 0.0f, Size), // East
                Point2 = GetCorner(0.5f, 0.86602540378f, Size), // SouthEast
                Point3 = GetCorner(-0.5f, 0.86602540378f, Size), // SouthWest
                Point4 = GetCorner(-1.0f, 0.0f, Size), // West
                Point5 = GetCorner(-0.5f, -0.86602540378f, Size) // NorthWest
            };

            return corners;
        }

        protected override float GetWidth()
        {
            return VertexToVertex;
        }

        protected override float GetHeight()
        {
            return SideToSide;
        }

        protected override Point2F DetermineOffset()
        {
            switch (OffsetCoordinatesType)
            {
                case OffsetCoordinatesType.Odd:
                    return new Point2F(Size, Apothem);
                case OffsetCoordinatesType.Even:
                    return new Point2F(Size, SideToSide);
                default:
                    throw new ArgumentOutOfRangeException(nameof(OffsetCoordinatesType), OffsetCoordinatesType, $"OffsetCoordinatesType {OffsetCoordinatesType} is not supported.");
            }
        }

        public override int GetWorldWidthInPixels(int worldMapColumns)
        {
            // assumes even
            var worldWidthInPixels = worldMapColumns * Constants.OneHalf * VertexToVertex + worldMapColumns * Constants.OneHalf * SideLength + VertexToVertex * Constants.OneQuarter;

            return (int)worldWidthInPixels;
        }

        public override int GetWorldHeightInPixels(int worldMapRows)
        {
            // assumes even
            var worldHeightInPixels = worldMapRows * SideToSide + Apothem;

            return (int)worldHeightInPixels;
        }

        protected override Direction[] GetRingDirections()
        {
            var directions = new [] { Direction.North, Direction.NorthEast, Direction.SouthEast, Direction.South, Direction.SouthWest, Direction.NorthWest };

            return directions;
        }
    }
}