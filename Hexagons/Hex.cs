using System;
using System.Collections.Generic;
using System.Linq;
using Zen.Hexagons.ExtensionMethods;

namespace Zen.Hexagons
{
    public abstract class Hex : IHex
    {
        protected readonly OffsetCoordinatesType OffsetCoordinatesType;

        public HexType HexType { get; set; }
        public float Size { get; set; }
        public float VertexToVertex { get; set; }
        public float SideToSide { get; set; }
        public float Apothem { get; set; }
        public float SideLength { get; set; }

        protected Hex(OffsetCoordinatesType offsetCoordinatesType)
        {
            OffsetCoordinatesType = offsetCoordinatesType;
        }

        public abstract HexCube OffsetCoordinatesToCube(HexOffsetCoordinates hexOffsetCoordinates);

        public HexAxial OffsetCoordinatesToAxial(HexOffsetCoordinates offsetCoordinates)
        {
            var cube = OffsetCoordinatesToCube(offsetCoordinates);
            var axial = CubeToAxial(cube);

            return axial;
        }

        public abstract HexOffsetCoordinates CubeToOffsetCoordinates(HexCube hexCube);

        public HexAxial CubeToAxial(HexCube hexCube)
        {
            var q = hexCube.X;
            var r = hexCube.Z;
            var axial = new HexAxial(q, r);

            return axial;
        }

        public HexOffsetCoordinates AxialToOffsetCoordinates(HexAxial hexAxial)
        {
            var cube = AxialToCube(hexAxial);
            var offsetCoordinates = CubeToOffsetCoordinates(cube);

            return offsetCoordinates;
        }

        public HexCube AxialToCube(HexAxial hexAxial)
        {
            var x = hexAxial.Q;
            var z = hexAxial.R;
            var y = -x - z;
            var cube = new HexCube(x, y, z);

            return cube;
        }

        public HexOffsetCoordinates[] GetAllNeighbors(HexOffsetCoordinates hexOffsetCoordinates)
        {
            var cube = OffsetCoordinatesToCube(hexOffsetCoordinates);
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

        public HexOffsetCoordinates GetNeighbor(HexOffsetCoordinates hexOffsetCoordinates, Direction direction)
        {
            var cube = OffsetCoordinatesToCube(hexOffsetCoordinates);
            var neighbor = GetNeighbor(cube, direction);
            var offsetCoordinates = CubeToOffsetCoordinates(neighbor);

            return offsetCoordinates;
        }

        public HexOffsetCoordinates[] GetSingleRing(HexOffsetCoordinates offsetCoordinates, int radius)
        {
            var ring = new List<HexOffsetCoordinates>();

            var cube = OffsetCoordinatesToCube(offsetCoordinates);
            var southWestNeighbor = GetNeighboringCube(Direction.SouthWest);
            var scaledCube = southWestNeighbor * radius;
            cube += scaledCube;

            var directions = GetRingDirections();
            foreach (var direction in directions)
            {
                for (var j = 0; j < radius; j++)
                {
                    var offset = CubeToOffsetCoordinates(cube);
                    if (!ring.Contains(offset))
                    {
                        ring.Add(offset);
                    }
                    cube = GetNeighbor(cube, direction);
                }
            }
            var singleRing = ring.ToArray();

            return singleRing;
        }

        protected abstract Direction[] GetRingDirections();

        public HexOffsetCoordinates[] GetSpiralRing(HexOffsetCoordinates offsetCoordinates, int radius)
        {
            var ring = new List<HexOffsetCoordinates> { offsetCoordinates };

            for (var k = 1; k <= radius; k++)
            {
                var singleRing = GetSingleRing(offsetCoordinates, k);
                ring.AddRange(singleRing.ToList());
            }
            var spiralRing = ring.ToArray();

            return spiralRing;
        }

        public List<HexOffsetCoordinates> GetLine(HexOffsetCoordinates fromOffsetCoordinates, HexOffsetCoordinates toOffsetCoordinates)
        {
            var fromCube = OffsetCoordinatesToCube(fromOffsetCoordinates);
            var toCube = OffsetCoordinatesToCube(toOffsetCoordinates);

            var hexes = GetLine(fromCube, toCube);

            var result = new List<HexOffsetCoordinates>();
            foreach (var hex in hexes)
            {
                var offsetCoordinates = CubeToOffsetCoordinates(hex);
                result.Add(offsetCoordinates);
            }

            return result;
        }

        public int GetDistance(HexOffsetCoordinates from, HexOffsetCoordinates to)
        {
            var fromCube = OffsetCoordinatesToCube(from);
            var toCube = OffsetCoordinatesToCube(to);

            var distance = GetDistance(fromCube, toCube);

            return distance;
        }

        public HexOffsetCoordinates FromPixelToOffsetCoordinates(int x, int y)
        {
            var cube = FromPixelToCube(x, y);
            var offsetCoordinates2 = CubeToOffsetCoordinates(cube);

            return offsetCoordinates2;
        }

        public abstract Point2F FromOffsetCoordinatesToPixel(HexOffsetCoordinates offsetCoordinates);

        public HexOffsetCoordinates RoundOffsetCoordinates(float x, float y)
        {
            var cube = RoundCube(x, -x - y, y);
            var offsetCoordinates = CubeToOffsetCoordinates(cube);

            return offsetCoordinates;
        }

        public HexCube[] GetAllNeighbors(HexCube hexCube)
        {
            var neighbors = new List<HexCube>();
            for (var i = 0; i < 8; i++)
            {
                var neighbor = GetNeighbor(hexCube, (Direction)i);
                if (neighbor != hexCube)
                {
                    neighbors.Add(neighbor);
                }
            }

            return neighbors.ToArray();
        }

        public HexCube GetNeighbor(HexCube hexCube, Direction direction)
        {
            var offset = GetNeighboringCube(direction);
            var neighbor = hexCube + offset;

            return neighbor;
        }

        public List<HexCube> GetLine(HexCube fromCube, HexCube toCube)
        {
            var distance = GetDistance(fromCube, toCube);

            var results = new List<HexCube>();
            for (var i = 0; i <= distance; i++)
            {
                var t = 1.0f / distance * i;
                var lerp = Lerp(fromCube, toCube, t);
                var hex = RoundCube(lerp.X, lerp.Y, lerp.Z);
                results.Add(hex);
            }

            return results;
        }

        public int GetDistance(HexCube fromCube, HexCube toCube)
        {
            var diffX = Math.Abs(fromCube.X - toCube.X);
            var diffY = Math.Abs(fromCube.Y - toCube.Y);
            var diffZ = Math.Abs(fromCube.Z - toCube.Z);
            var distance1 = (diffX + diffY + diffZ) / 2;
            var distance2 = Math.Max(Math.Max(diffX, diffY), diffZ);

            if (distance1 != distance2) throw new Exception("distance1 not equal to distance2!");

            return distance1;
        }

        public HexCube FromPixelToCube(int x, int y)
        {
            var axial = FromPixelToAxial(x, y);
            var cube = AxialToCube(axial);

            return cube;
        }

        public Point2F FromCubeToPixel(HexCube cube)
        {
            var axial = CubeToAxial(cube);
            var pixel = FromAxialToPixel(axial);

            return pixel;
        }

        public HexCube RoundCube(float x, float y, float z)
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
            var cube = new HexCube(rx, ry, rz);

            return cube;
        }

        public abstract HexAxial FromPixelToAxial(int x, int y);

        public abstract Point2F FromAxialToPixel(HexAxial axial);

        public HexAxial RoundAxial(float q, float r)
        {
            var cube = RoundCube(q, -q - r, r);
            var axial = CubeToAxial(cube);

            return axial;
        }

        public Point3F Lerp(HexCube a, HexCube b, float t)
        {
            var x = t.Lerp(a.X, b.X);
            var y = t.Lerp(a.Y, b.Y);
            var z = t.Lerp(a.Z, b.Z);
            var foo = new Point3F(x, y, z);

            return foo;
        }

        public abstract Point2F[] GetCorners();

        public abstract int GetHexWidth();
        public abstract int GetHexHeight();
        public abstract int GetWorldWidthInPixels(int worldMapColumns);
        public abstract int GetWorldHeightInPixels(int worldMapRows);

        protected abstract HexCube GetNeighboringCube(Direction direction);

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