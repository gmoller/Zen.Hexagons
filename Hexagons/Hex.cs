using System;
using System.Collections.Generic;
using System.Linq;
using Zen.Hexagons.ExtensionMethods;

namespace Zen.Hexagons
{
    public abstract class Hex : IHex
    {
        protected readonly OffsetCoordinatesType OffsetCoordinatesType;

        public HexType HexType { get; }
        public float Size { get; }
        public float Width { get; }
        public float Height { get; }
        public float Apothem { get; }
        public float SideToSide { get; }
        public float Perimeter { get; }
        public float SideLength { get; }
        public float CenterToVertex { get; }
        public float VertexToVertex { get; }

        protected Hex(HexType hexType, OffsetCoordinatesType offsetCoordinatesType, float hexSize)
        {
            OffsetCoordinatesType = offsetCoordinatesType;
            HexType = hexType;

            Apothem = (float)(Constants.SquareRootOf3 * hexSize * Constants.OneHalf);
            SideToSide = (float)(Constants.SquareRootOf3 * hexSize);
            Perimeter = hexSize * 6;
            SideLength = hexSize;
            CenterToVertex = hexSize;
            VertexToVertex = hexSize * 2;

            Size = hexSize;
            Width = GetWidth();
            Height = GetHeight();
        }

        protected abstract float GetWidth();

        protected abstract float GetHeight();

        public abstract HexCubeCoordinates OffsetCoordinatesToCube(HexOffsetCoordinates offset);

        public HexAxialCoordinates OffsetCoordinatesToAxial(HexOffsetCoordinates offset)
        {
            var cube = OffsetCoordinatesToCube(offset);
            var axial = CubeToAxial(cube);

            return axial;
        }

        public abstract HexOffsetCoordinates CubeToOffsetCoordinates(HexCubeCoordinates cube);

        public HexAxialCoordinates CubeToAxial(HexCubeCoordinates cube)
        {
            var q = cube.X;
            var r = cube.Z;
            var axial = new HexAxialCoordinates(q, r);

            return axial;
        }

        public HexOffsetCoordinates AxialToOffsetCoordinates(HexAxialCoordinates axial)
        {
            var cube = AxialToCube(axial);
            var offsetCoordinates = CubeToOffsetCoordinates(cube);

            return offsetCoordinates;
        }

        public HexCubeCoordinates AxialToCube(HexAxialCoordinates axial)
        {
            var x = axial.Q;
            var z = axial.R;
            var y = -x - z;
            var cube = new HexCubeCoordinates(x, y, z);

            return cube;
        }

        public HexOffsetCoordinates[] GetAllNeighbors(HexOffsetCoordinates offset)
        {
            var cube = OffsetCoordinatesToCube(offset);
            var allNeighboringCubes = GetAllNeighbors(cube);

            var neighbors = new HexOffsetCoordinates[6];
            for (var i = 0; i < 6; i++)
            {
                var neighboringCube = allNeighboringCubes[i];
                var neighboring = CubeToOffsetCoordinates(neighboringCube);
                neighbors[i] = neighboring;
            }

            return neighbors;
        }

        public HexOffsetCoordinates GetNeighbor(HexOffsetCoordinates offset, Direction direction)
        {
            var cube = OffsetCoordinatesToCube(offset);
            var neighbor = GetNeighbor(cube, direction);
            var returnOffset = CubeToOffsetCoordinates(neighbor);

            return returnOffset;
        }

        public HexOffsetCoordinates[] GetSingleRing(HexOffsetCoordinates offset, int radius)
        {
            var ring = new List<HexOffsetCoordinates>();

            var cube = OffsetCoordinatesToCube(offset);
            var southWestNeighbor = GetNeighboringCube(Direction.SouthWest);
            var scaledCube = southWestNeighbor * radius;
            cube += scaledCube;

            var directions = GetRingDirections();
            foreach (var direction in directions)
            {
                for (var j = 0; j < radius; j++)
                {
                    var returnOffset = CubeToOffsetCoordinates(cube);
                    if (!ring.Contains(returnOffset))
                    {
                        ring.Add(returnOffset);
                    }
                    cube = GetNeighbor(cube, direction);
                }
            }
            var singleRing = ring.ToArray();

            return singleRing;
        }

        protected abstract Direction[] GetRingDirections();

        public HexOffsetCoordinates[] GetSpiralRing(HexOffsetCoordinates offset, int radius)
        {
            var ring = new List<HexOffsetCoordinates> { offset };

            for (var k = 1; k <= radius; k++)
            {
                var singleRing = GetSingleRing(offset, k);
                ring.AddRange(singleRing.ToList());
            }
            var spiralRing = ring.ToArray();

            return spiralRing;
        }

        public List<HexOffsetCoordinates> GetLine(HexOffsetCoordinates fromOffset, HexOffsetCoordinates toOffset)
        {
            var fromCube = OffsetCoordinatesToCube(fromOffset);
            var toCube = OffsetCoordinatesToCube(toOffset);

            var hexes = GetLine(fromCube, toCube);

            var result = new List<HexOffsetCoordinates>();
            foreach (var hex in hexes)
            {
                var offsetCoordinates = CubeToOffsetCoordinates(hex);
                result.Add(offsetCoordinates);
            }

            return result;
        }

        public int GetDistance(HexOffsetCoordinates fromOffset, HexOffsetCoordinates toOffset)
        {
            var fromCube = OffsetCoordinatesToCube(fromOffset);
            var toCube = OffsetCoordinatesToCube(toOffset);

            var distance = GetDistance(fromCube, toCube);

            return distance;
        }

        public HexOffsetCoordinates FromPixelToOffsetCoordinates(int x, int y)
        {
            var cube = FromPixelToCube(x, y);
            var offsetCoordinates2 = CubeToOffsetCoordinates(cube);

            return offsetCoordinates2;
        }

        public abstract Point2F FromOffsetCoordinatesToPixel(HexOffsetCoordinates offset);

        public HexOffsetCoordinates RoundOffsetCoordinates(float x, float y)
        {
            var cube = RoundCube(x, -x - y, y);
            var offsetCoordinates = CubeToOffsetCoordinates(cube);

            return offsetCoordinates;
        }

        public HexCubeCoordinates[] GetAllNeighbors(HexCubeCoordinates cube)
        {
            var neighbors = new List<HexCubeCoordinates>();
            for (var i = 0; i < 8; i++)
            {
                var neighbor = GetNeighbor(cube, (Direction)i);
                if (neighbor != cube)
                {
                    neighbors.Add(neighbor);
                }
            }

            return neighbors.ToArray();
        }

        public HexCubeCoordinates GetNeighbor(HexCubeCoordinates cube, Direction direction)
        {
            var offset = GetNeighboringCube(direction);
            var neighbor = cube + offset;

            return neighbor;
        }

        public List<HexCubeCoordinates> GetLine(HexCubeCoordinates fromCube, HexCubeCoordinates toCube)
        {
            var distance = GetDistance(fromCube, toCube);

            var results = new List<HexCubeCoordinates>();
            for (var i = 0; i <= distance; i++)
            {
                var t = 1.0f / distance * i;
                var lerp = Lerp(fromCube, toCube, t);
                var hex = RoundCube(lerp.X, lerp.Y, lerp.Z);
                results.Add(hex);
            }

            return results;
        }

        public int GetDistance(HexCubeCoordinates fromCube, HexCubeCoordinates toCube)
        {
            var diffX = Math.Abs(fromCube.X - toCube.X);
            var diffY = Math.Abs(fromCube.Y - toCube.Y);
            var diffZ = Math.Abs(fromCube.Z - toCube.Z);
            var distance1 = (diffX + diffY + diffZ) / 2;
            var distance2 = Math.Max(Math.Max(diffX, diffY), diffZ);

            if (distance1 != distance2) throw new Exception("distance1 not equal to distance2!");

            return distance1;
        }

        public HexCubeCoordinates FromPixelToCube(int x, int y)
        {
            var axial = FromPixelToAxial(x, y);
            var cube = AxialToCube(axial);

            return cube;
        }

        public Point2F FromCubeToPixel(HexCubeCoordinates cube)
        {
            var axial = CubeToAxial(cube);
            var pixel = FromAxialToPixel(axial);

            return pixel;
        }

        public HexCubeCoordinates RoundCube(float x, float y, float z)
        {
            var rx = (int)Math.Round(x);
            var ry = (int)Math.Round(y);
            var rz = (int)Math.Round(z);

            //var zero = rx + ry + rz;

            var xDiff = Math.Abs(rx - x);
            var yDiff = Math.Abs(ry - y);
            var zDiff = Math.Abs(rz - z);

            if (xDiff > yDiff && xDiff > zDiff)
            {
                rx = -ry - rz;
            }
            else if (yDiff > zDiff)
            {
                ry = -rx - rz;
            }
            else
            {
                rz = -rx - ry;
            }
            var cube = new HexCubeCoordinates(rx, ry, rz);

            return cube;
        }

        public abstract HexAxialCoordinates FromPixelToAxial(int x, int y);

        public abstract Point2F FromAxialToPixel(HexAxialCoordinates axial);

        public HexAxialCoordinates RoundAxial(float q, float r)
        {
            var cube = RoundCube(q, -q - r, r);
            var axial = CubeToAxial(cube);

            return axial;
        }

        public Point3F Lerp(HexCubeCoordinates fromCube, HexCubeCoordinates toCube, float t)
        {
            var x = t.Lerp(fromCube.X, toCube.X);
            var y = t.Lerp(fromCube.Y, toCube.Y);
            var z = t.Lerp(fromCube.Z, toCube.Z);
            var foo = new Point3F(x, y, z);

            return foo;
        }

        public abstract Point2F[] GetCorners();

        public abstract int GetWorldWidthInPixels(int worldMapColumns);
        public abstract int GetWorldHeightInPixels(int worldMapRows);

        protected abstract HexCubeCoordinates GetNeighboringCube(Direction direction);

        protected Point2F GetCorner(Direction direction)
        {
            var degrees = GetDegreesForHexCorner(direction);
            var radians = degrees.ToRadians();
            var v = new Point2F((float)(Size * Math.Cos(radians)), (float)(Size * Math.Sin(radians)));

            return v;
        }

        protected abstract float GetDegreesForHexCorner(Direction direction);
    }
}