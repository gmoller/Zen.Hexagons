using System;
using System.Collections.Generic;

namespace Zen.Hexagons
{
    public class HexPointyTopped : Hex
    {
        private static readonly HexCube[] Directions =
        {
            new HexCube( 0,  0,  0), // north
            new HexCube(+1,  0, -1), // northeast
            new HexCube(+1, -1,  0), // east
            new HexCube( 0, -1, +1), // southeast
            new HexCube( 0,  0,  0), // south
            new HexCube(-1,  0, +1), // southwest
            new HexCube(-1, +1,  0), // west
            new HexCube( 0, +1, -1), // northwest
        };

        public HexPointyTopped(OffsetCoordinatesType offsetCoordinatesType) : base(offsetCoordinatesType)
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

            col -= OffsetCoordinatesType switch
            {
                OffsetCoordinatesType.Even => (row + (row & 1)) / 2,
                OffsetCoordinatesType.Odd => (row - (row & 1)) / 2,
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

            col += OffsetCoordinatesType switch
            {
                OffsetCoordinatesType.Even => (row + (row & 1)) / 2,
                OffsetCoordinatesType.Odd => (row - (row & 1)) / 2,
                _ => throw new ArgumentOutOfRangeException(nameof(OffsetCoordinatesType), OffsetCoordinatesType, $"OffsetCoordinatesType {OffsetCoordinatesType} is not supported.")
            };

            var offsetCoordinates = new HexOffsetCoordinates(col, row);

            return offsetCoordinates;
        }

        public override Point2F FromOffsetCoordinatesToPixel(HexOffsetCoordinates offsetCoordinates)
        {
            var x = Size;
            var y = Size * (1.5f * offsetCoordinates.Row);

            x *= OffsetCoordinatesType switch
            {
                OffsetCoordinatesType.Even => (float)(Constants.SquareRootOf3 * (offsetCoordinates.Col - 0.5f * (offsetCoordinates.Row & 1))),
                OffsetCoordinatesType.Odd => (float)(Constants.SquareRootOf3 * (offsetCoordinates.Col + 0.5f * (offsetCoordinates.Row & 1))),
                _ => throw new ArgumentOutOfRangeException(nameof(OffsetCoordinatesType), OffsetCoordinatesType, $"OffsetCoordinatesType {OffsetCoordinatesType} is not supported.")
            };

            var pixel = new Point2F(x, y);

            return pixel;
        }

        public override HexAxial FromPixelToAxial(int x, int y)
        {
            var q = (float)((Constants.OneThirdOfSquareRootOf3 * x - Constants.OneThird * y) / Size);
            var r = (float)(Constants.TwoThirds * y / Size);
            var axial = RoundAxial(q, r);

            return axial;
        }

        public override Point2F FromAxialToPixel(HexAxial axial)
        {
            var x = (float)(Size * (Constants.SquareRootOf3 * axial.Q + Constants.HalfOfSquareRootOf3 * axial.R));
            var y = Size * (1.5f * axial.R);
            var pixel = new Point2F(x, y);

            return pixel;
        }

        public override Point2F[] GetCorners()
        {
            var corners = new Point2F[6];
            corners[0] = GetCorner(Direction.North);
            corners[1] = GetCorner(Direction.NorthEast);
            corners[2] = GetCorner(Direction.SouthEast);
            corners[3] = GetCorner(Direction.South);
            corners[4] = GetCorner(Direction.SouthWest);
            corners[5] = GetCorner(Direction.NorthWest);

            return corners;
        }

        public override int GetHexWidth()
        {
            return (int)SideToSide;
        }

        public override int GetHexHeight()
        {
            return (int)VertexToVertex;
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

        protected override float GetDegreesForHexCorner(Direction direction)
        {
            float degrees;

            switch (direction)
            {
                case Direction.North:
                    degrees = 270;
                    break;
                case Direction.NorthEast:
                    degrees = 330;
                    break;
                case Direction.SouthEast:
                    degrees = 30;
                    break;
                case Direction.South:
                    degrees = 90;
                    break;
                case Direction.SouthWest:
                    degrees = 150;
                    break;
                case Direction.NorthWest:
                    degrees = 210;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
            }

            return degrees;
        }

        protected override Direction[] GetRingDirections()
        {
            var directions = new [] { Direction.NorthWest, Direction.NorthEast, Direction.East, Direction.SouthEast, Direction.SouthWest, Direction.West };

            return directions;
        }
    }
}