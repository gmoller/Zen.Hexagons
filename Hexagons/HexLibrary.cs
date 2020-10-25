using System;

namespace Zen.Hexagons
{
    // https://hexagoncalculator.apphb.com/
    // https://www.redblobgames.com/grids/hexagons/

    public class HexLibrary : IHex
    {
        private readonly IHex _hex;

        public HexLibrary(HexType hexType, OffsetCoordinatesType offsetCoordinatesType, float hexSize, bool align00With00 = true)
        {
            _hex = hexType switch
            {
                HexType.FlatTopped => new HexFlatTopped(offsetCoordinatesType, hexSize, align00With00),
                HexType.PointyTopped => new HexPointyTopped(offsetCoordinatesType, hexSize, align00With00),
                _ => throw new ArgumentOutOfRangeException(nameof(hexType), hexType, $"HexType {hexType} is not supported.")
            };
        }

        public HexType HexType => _hex.HexType;
        public float Size => _hex.Size;
        public float Width => _hex.Width;
        public float Height => _hex.Height;
        public float Apothem => _hex.Apothem;
        public float SideToSide => _hex.SideToSide;
        public float Perimeter => _hex.Perimeter;
        public float SideLength => _hex.SideLength;
        public float CenterToVertex => _hex.CenterToVertex;
        public float VertexToVertex => _hex.VertexToVertex;

        public HexCubeCoordinates OffsetCoordinatesToCube(HexOffsetCoordinates offset) => _hex.OffsetCoordinatesToCube(offset);
        public HexAxialCoordinates OffsetCoordinatesToAxial(HexOffsetCoordinates offset) => _hex.OffsetCoordinatesToAxial(offset);
        public HexOffsetCoordinates CubeToOffsetCoordinates(HexCubeCoordinates cube) => _hex.CubeToOffsetCoordinates(cube);
        public HexAxialCoordinates CubeToAxial(HexCubeCoordinates cube) => _hex.CubeToAxial(cube);
        public HexOffsetCoordinates AxialToOffsetCoordinates(HexAxialCoordinates axial) => _hex.AxialToOffsetCoordinates(axial);
        public HexCubeCoordinates AxialToCube(HexAxialCoordinates axial) => _hex.AxialToCube(axial);

        public HexOffsetCoordinatesSextuple GetAllNeighbors(HexOffsetCoordinates offset) => _hex.GetAllNeighbors(offset);
        public HexOffsetCoordinates GetNeighbor(HexOffsetCoordinates offset, Direction direction) => _hex.GetNeighbor(offset, direction);
        public HexOffsetCoordinates[] GetSingleRing(HexOffsetCoordinates offset, int radius) => _hex.GetSingleRing(offset, radius);
        public HexOffsetCoordinates[] GetSpiralRing(HexOffsetCoordinates offset, int radius) => _hex.GetSpiralRing(offset, radius);
        public HexOffsetCoordinates[] GetLine(HexOffsetCoordinates fromOffset, HexOffsetCoordinates toOffset) => _hex.GetLine(fromOffset, toOffset);
        public int GetDistance(HexOffsetCoordinates fromOffset, HexOffsetCoordinates toOffset) => _hex.GetDistance(fromOffset, toOffset);
        public Point2F FromOffsetCoordinatesToPixel(HexOffsetCoordinates offset) => _hex.FromOffsetCoordinatesToPixel(offset);
        public HexOffsetCoordinates FromPixelToOffsetCoordinates(int x, int y) => _hex.FromPixelToOffsetCoordinates(x, y);
        public HexOffsetCoordinates RoundOffsetCoordinates(float x, float y) => _hex.RoundOffsetCoordinates(x, y);

        public HexCubeCoordinates[] GetAllNeighbors(HexCubeCoordinates cube) => _hex.GetAllNeighbors(cube);
        public HexCubeCoordinates GetNeighbor(HexCubeCoordinates cube, Direction direction) => _hex.GetNeighbor(cube, direction);
        public HexCubeCoordinates[] GetLine(HexCubeCoordinates fromCube, HexCubeCoordinates toCube) => _hex.GetLine(fromCube, toCube);
        public int GetDistance(HexCubeCoordinates fromCube, HexCubeCoordinates toCube) => _hex.GetDistance(fromCube, toCube);
        public HexCubeCoordinates FromPixelToCube(int x, int y) => _hex.FromPixelToCube(x, y);
        public Point2F FromCubeToPixel(HexCubeCoordinates cube) => _hex.FromCubeToPixel(cube);
        public HexCubeCoordinates RoundCube(float x, float y, float z) => _hex.RoundCube(x, y, z);

        public HexAxialCoordinates FromPixelToAxial(int x, int y) => _hex.FromPixelToAxial(x, y);
        public Point2F FromAxialToPixel(HexAxialCoordinates axial) => _hex.FromAxialToPixel(axial);
        public HexAxialCoordinates RoundAxial(float q, float r) => _hex.RoundAxial(q, r);

        public Point3F Lerp(HexCubeCoordinates fromCube, HexCubeCoordinates toCube, float t) => _hex.Lerp(fromCube, toCube, t);

        public Point2FSextuple GetCorners() => _hex.GetCorners();
        public int GetWorldWidthInPixels(int worldMapColumns) => _hex.GetWorldWidthInPixels(worldMapColumns);
        public int GetWorldHeightInPixels(int worldMapRows) => _hex.GetWorldHeightInPixels(worldMapRows);
    }
}