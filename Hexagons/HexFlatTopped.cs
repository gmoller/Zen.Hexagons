using System;

namespace Zen.Hexagons
{
    public class HexFlatTopped : Hex
    {
        private static readonly HexCube[] Directions =
        {
            new HexCube( 0, +1, -1), // north
            new HexCube(+1,  0, -1), // northeast
            new HexCube( 0,  0,  0), // east
            new HexCube(+1, -1,  0), // southeast
            new HexCube( 0, -1, +1), // south
            new HexCube(-1,  0, +1), // southwest
            new HexCube( 0,  0,  0), // west
            new HexCube(-1, +1,  0), // northwest
        };

        public HexFlatTopped(OffsetCoordinatesType offsetCoordinatesType) : base(offsetCoordinatesType)
        {
        }


        protected override HexCube GetNeighboringCube(Direction direction)
        {
            var neighboringCube = Directions[(int)direction];

            return neighboringCube;
        }


        public override HexCube OffsetCoordinatesToCube(HexOffsetCoordinates hexOffsetCoordinates)
        {
            var col = hexOffsetCoordinates.Col;
            var row = hexOffsetCoordinates.Row;

            row -= OffsetCoordinatesType switch
            {
                OffsetCoordinatesType.Even => (col + (col & 1)) / 2,
                OffsetCoordinatesType.Odd => (col - (col & 1)) / 2,
                _ => throw new ArgumentOutOfRangeException(nameof(OffsetCoordinatesType), OffsetCoordinatesType, $"OffsetCoordinatesType {OffsetCoordinatesType} is not supported.")
            };
            var y = -col - row;
            var cube = new HexCube(col, y, row);

            return cube;
        }

        public override HexOffsetCoordinates CubeToOffsetCoordinates(HexCube hexCube)
        {
            var col = hexCube.X;
            var row = hexCube.Z;

            row += OffsetCoordinatesType switch
            {
                OffsetCoordinatesType.Even => (col + (col & 1)) / 2,
                OffsetCoordinatesType.Odd => (col - (col & 1)) / 2,
                _ => throw new ArgumentOutOfRangeException(nameof(OffsetCoordinatesType), OffsetCoordinatesType, $"OffsetCoordinatesType {OffsetCoordinatesType} is not supported.")
            };

            var offsetCoordinates = new HexOffsetCoordinates(col, row);

            return offsetCoordinates;
        }

        public override Point2F FromOffsetCoordinatesToPixel(HexOffsetCoordinates offsetCoordinates)
        {
            var x = Size * (1.5f * offsetCoordinates.Col);
            var y = Size;

            y *= OffsetCoordinatesType switch
            {
                OffsetCoordinatesType.Even => (float)(Constants.SquareRootOf3 * (offsetCoordinates.Row - 0.5f * (offsetCoordinates.Col & 1))),
                OffsetCoordinatesType.Odd => (float)(Constants.SquareRootOf3 * (offsetCoordinates.Row + 0.5f * (offsetCoordinates.Col & 1))),
                _ => throw new ArgumentOutOfRangeException(nameof(OffsetCoordinatesType), OffsetCoordinatesType, $"OffsetCoordinatesType {OffsetCoordinatesType} is not supported.")
            };

            var pixel = new Point2F(x, y);

            return pixel;
        }

        public override HexAxial FromPixelToAxial(int x, int y)
        {
            var q = (float)(Constants.TwoThirds * x / Size);
            var r = (float)((-Constants.OneThird * x + Constants.OneThirdOfSquareRootOf3 * y) / Size);
            var axial = RoundAxial(q, r);

            return axial;
        }

        public override Point2F FromAxialToPixel(HexAxial axial)
        {
            var x = Size * (1.5f * axial.Q);
            var y = (float)(Size * (Constants.HalfOfSquareRootOf3 * axial.Q + Constants.SquareRootOf3 * axial.R));
            var pixel = new Point2F(x, y);

            return pixel;
        }

        public override Point2F[] GetCorners()
        {
            var corners = new Point2F[6];
            corners[0] = GetCorner(Direction.NorthEast);
            corners[1] = GetCorner(Direction.East);
            corners[2] = GetCorner(Direction.SouthEast);
            corners[3] = GetCorner(Direction.SouthWest);
            corners[4] = GetCorner(Direction.West);
            corners[5] = GetCorner(Direction.NorthWest);

            return corners;
        }

        public override int GetHexWidth()
        {
            return (int)VertexToVertex;
        }

        public override int GetHexHeight()
        {
            return (int)SideToSide;
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

        protected override float GetDegreesForHexCorner(Direction direction)
        {
            float degrees;

            switch (direction)
            {
                case Direction.NorthEast:
                    degrees = 300;
                    break;
                case Direction.East:
                    degrees = 0;
                    break;
                case Direction.SouthEast:
                    degrees = 60;
                    break;
                case Direction.SouthWest:
                    degrees = 120;
                    break;
                case Direction.West:
                    degrees = 180;
                    break;
                case Direction.NorthWest:
                    degrees = 240;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
            }

            return degrees;
        }

        protected override Direction[] GetRingDirections()
        {
            var directions = new [] { Direction.North, Direction.NorthEast, Direction.SouthEast, Direction.South, Direction.SouthWest, Direction.NorthWest };

            return directions;
        }
    }
}