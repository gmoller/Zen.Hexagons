using System;
using System.Linq;
using Zen.Hexagons.ExtensionMethods;

namespace Zen.Hexagons
{
    public abstract class Hex : IHex
    {
        protected OffsetCoordinatesType OffsetCoordinatesType { get; }
        protected Point2F Offset { get; }

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

        protected Hex(HexType hexType, OffsetCoordinatesType offsetCoordinatesType, float hexSize, bool align00With00)
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

            Offset = align00With00 ? Point2F.Zero : DetermineOffset();
        }

        protected abstract float GetWidth();

        protected abstract float GetHeight();

        protected abstract Point2F DetermineOffset();

        public abstract HexCubeCoordinates OffsetToCubeCoordinates(HexOffsetCoordinates offset);

        public HexAxialCoordinates OffsetToAxialCoordinates(HexOffsetCoordinates offset)
        {
            var cube = OffsetToCubeCoordinates(offset);
            var axial = CubeToAxialCoordinates(cube);

            return axial;
        }

        public abstract HexOffsetCoordinates CubeToOffsetCoordinates(HexCubeCoordinates cube);

        public HexAxialCoordinates CubeToAxialCoordinates(HexCubeCoordinates cube)
        {
            var q = cube.X;
            var r = cube.Z;
            var axial = new HexAxialCoordinates(q, r);

            return axial;
        }

        public HexOffsetCoordinates AxialToOffsetCoordinates(HexAxialCoordinates axial)
        {
            var cube = AxialToCubeCoordinates(axial);
            var offsetCoordinates = CubeToOffsetCoordinates(cube);

            return offsetCoordinates;
        }

        public HexCubeCoordinates AxialToCubeCoordinates(HexAxialCoordinates axial)
        {
            var x = axial.Q;
            var z = axial.R;
            var y = -x - z;
            var cube = new HexCubeCoordinates(x, y, z);

            return cube;
        }

        public HexOffsetCoordinatesSextuple GetAllNeighbors(HexOffsetCoordinates offset)
        {
            var cube = OffsetToCubeCoordinates(offset);
            var allNeighboringCubes = GetAllNeighbors(cube);

            var neighbors = new HexOffsetCoordinatesSextuple();

            var neighboringCube = allNeighboringCubes.HexCubeCoordinates0;
            var neighboring = CubeToOffsetCoordinates(neighboringCube);
            neighbors.HexOffsetCoordinates0 = neighboring;

            neighboringCube = allNeighboringCubes.HexCubeCoordinates1;
            neighboring = CubeToOffsetCoordinates(neighboringCube);
            neighbors.HexOffsetCoordinates1 = neighboring;

            neighboringCube = allNeighboringCubes.HexCubeCoordinates2;
            neighboring = CubeToOffsetCoordinates(neighboringCube);
            neighbors.HexOffsetCoordinates2 = neighboring;

            neighboringCube = allNeighboringCubes.HexCubeCoordinates3;
            neighboring = CubeToOffsetCoordinates(neighboringCube);
            neighbors.HexOffsetCoordinates3 = neighboring;

            neighboringCube = allNeighboringCubes.HexCubeCoordinates4;
            neighboring = CubeToOffsetCoordinates(neighboringCube);
            neighbors.HexOffsetCoordinates4 = neighboring;

            neighboringCube = allNeighboringCubes.HexCubeCoordinates5;
            neighboring = CubeToOffsetCoordinates(neighboringCube);
            neighbors.HexOffsetCoordinates5 = neighboring;

            return neighbors;
        }

        public HexOffsetCoordinates GetNeighbor(HexOffsetCoordinates offset, Direction direction)
        {
            var cube = OffsetToCubeCoordinates(offset);
            var neighbor = GetNeighbor(cube, direction);
            var returnOffset = CubeToOffsetCoordinates(neighbor);

            return returnOffset;
        }

        public HexOffsetCoordinates[] GetSingleRing(HexOffsetCoordinates offset, int radius)
        {
            var arraySize = 6 * radius;
            var singleRing = InstantiateArray(arraySize);

            var cube = OffsetToCubeCoordinates(offset);
            var southWestNeighbor = GetNeighboringCube(Direction.SouthWest);
            var scaledCube = southWestNeighbor * radius;
            cube += scaledCube;

            var directions = GetRingDirections();
            var cnt = 0;
            foreach (var direction in directions)
            {
                for (var j = 0; j < radius; j++)
                {
                    var returnOffset = CubeToOffsetCoordinates(cube);
                    if (!singleRing.Contains(returnOffset))
                    {
                        singleRing[cnt] = returnOffset;
                        cnt++;
                    }
                    cube = GetNeighbor(cube, direction);
                }
            }

            return singleRing;
        }

        protected abstract Direction[] GetRingDirections();

        public HexOffsetCoordinates[] GetSpiralRing(HexOffsetCoordinates offset, int radius)
        {
            var arraySize = 1 + 3 * radius * (radius + 1);
            var spiralRing  = InstantiateArray(arraySize);

            var cnt = 0;
            spiralRing[cnt] = offset;
            cnt++;

            for (var k = 1; k <= radius; k++)
            {
                var singleRing = GetSingleRing(offset, k);

                foreach (var item in singleRing)
                {
                    spiralRing[cnt] = item;
                    cnt++;
                }
            }

            return spiralRing;
        }

        private HexOffsetCoordinates[] InstantiateArray(int size)
        {
            var array = new HexOffsetCoordinates[size];
            for (var i = 0; i < size; i++)
            {
                array[i] = new HexOffsetCoordinates(-1, -1);
            }

            return array;
        }

        public HexOffsetCoordinates[] GetLine(HexOffsetCoordinates fromOffset, HexOffsetCoordinates toOffset)
        {
            var fromCube = OffsetToCubeCoordinates(fromOffset);
            var toCube = OffsetToCubeCoordinates(toOffset);

            var hexes = GetLine(fromCube, toCube);

            var results = new HexOffsetCoordinates[hexes.Length];
            for (var i = 0; i < hexes.Length; i++)
            {
                var hex = hexes[i];
                var offsetCoordinates = CubeToOffsetCoordinates(hex);
                results[i] = offsetCoordinates;
            }

            return results;
        }

        public int GetDistance(HexOffsetCoordinates fromOffset, HexOffsetCoordinates toOffset)
        {
            var fromCube = OffsetToCubeCoordinates(fromOffset);
            var toCube = OffsetToCubeCoordinates(toOffset);

            var distance = GetDistance(fromCube, toCube);

            return distance;
        }

        public abstract Point2F FromOffsetCoordinatesToPixel(HexOffsetCoordinates offset);

        public HexOffsetCoordinates FromPixelToOffsetCoordinates(int x, int y)
        {
            var cube = FromPixelToCubeCoordinates(x - (int)Offset.X, y - (int)Offset.Y);
            var offset = CubeToOffsetCoordinates(cube);

            return offset;
        }

        public HexOffsetCoordinates RoundOffsetCoordinates(float x, float y)
        {
            var cube = RoundCubeCoordinates(x, -x - y, y);
            var offsetCoordinates = CubeToOffsetCoordinates(cube);

            return offsetCoordinates;
        }

        public abstract HexCubeCoordinatesSextuple GetAllNeighbors(HexCubeCoordinates cube);

        public HexCubeCoordinates GetNeighbor(HexCubeCoordinates cube, Direction direction)
        {
            var offset = GetNeighboringCube(direction);
            var neighbor = cube + offset;

            return neighbor;
        }

        public HexCubeCoordinates[] GetLine(HexCubeCoordinates fromCube, HexCubeCoordinates toCube)
        {
            var distance = GetDistance(fromCube, toCube);

            var results = new HexCubeCoordinates[distance + 1];
            for (var i = 0; i <= distance; i++)
            {
                var t = 1.0f / distance * i;
                var lerp = Lerp(fromCube, toCube, t);
                var hex = RoundCubeCoordinates(lerp.X, lerp.Y, lerp.Z);
                results[i] = hex;
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

        public HexCubeCoordinates FromPixelToCubeCoordinates(int x, int y)
        {
            var axial = FromPixelToAxialCoordinates(x, y);
            var cube = AxialToCubeCoordinates(axial);

            return cube;
        }

        public Point2F FromCubeCoordinatesToPixel(HexCubeCoordinates cube)
        {
            var axial = CubeToAxialCoordinates(cube);
            var pixel = FromAxialCoordinatesToPixel(axial);

            return pixel;
        }

        public HexCubeCoordinates RoundCubeCoordinates(float x, float y, float z)
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

        public abstract HexAxialCoordinates FromPixelToAxialCoordinates(int x, int y);

        public abstract Point2F FromAxialCoordinatesToPixel(HexAxialCoordinates axial);

        public HexAxialCoordinates RoundAxialCoordinates(float q, float r)
        {
            var cube = RoundCubeCoordinates(q, -q - r, r);
            var axial = CubeToAxialCoordinates(cube);

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

        public abstract Point2FSextuple GetCorners();

        public abstract int GetWorldWidthInPixels(int worldMapColumns);
        public abstract int GetWorldHeightInPixels(int worldMapRows);

        protected abstract HexCubeCoordinates GetNeighboringCube(Direction direction);

        protected Point2F GetCorner(float cos, float sin, float size)
        {
            var x = size * cos;
            var y = size * sin;
            var p = new Point2F((float)x, (float)y);

            return p;
        }
    }
}