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

        public HexCubeCoordinates OffsetToCubeCoordinates(HexOffsetCoordinates offset) => _hex.OffsetToCubeCoordinates(offset);
        public HexAxialCoordinates OffsetToAxialCoordinates(HexOffsetCoordinates offset) => _hex.OffsetToAxialCoordinates(offset);
        public HexOffsetCoordinates CubeToOffsetCoordinates(HexCubeCoordinates cube) => _hex.CubeToOffsetCoordinates(cube);
        public HexAxialCoordinates CubeToAxialCoordinates(HexCubeCoordinates cube) => _hex.CubeToAxialCoordinates(cube);
        public HexOffsetCoordinates AxialToOffsetCoordinates(HexAxialCoordinates axial) => _hex.AxialToOffsetCoordinates(axial);
        public HexCubeCoordinates AxialToCubeCoordinates(HexAxialCoordinates axial) => _hex.AxialToCubeCoordinates(axial);

        public HexOffsetCoordinatesSextuple GetAllNeighbors(HexOffsetCoordinates offset) => _hex.GetAllNeighbors(offset);
        public HexOffsetCoordinates GetNeighbor(HexOffsetCoordinates offset, Direction direction) => _hex.GetNeighbor(offset, direction);
        public HexOffsetCoordinates[] GetSingleRing(HexOffsetCoordinates offset, int radius) => _hex.GetSingleRing(offset, radius);
        public HexOffsetCoordinates[] GetSpiralRing(HexOffsetCoordinates offset, int radius) => _hex.GetSpiralRing(offset, radius);
        public HexOffsetCoordinates[] GetLine(HexOffsetCoordinates fromOffset, HexOffsetCoordinates toOffset) => _hex.GetLine(fromOffset, toOffset);
        public int GetDistance(HexOffsetCoordinates fromOffset, HexOffsetCoordinates toOffset) => _hex.GetDistance(fromOffset, toOffset);
        public Point2F FromOffsetCoordinatesToPixel(HexOffsetCoordinates offset) => _hex.FromOffsetCoordinatesToPixel(offset);
        public HexOffsetCoordinates FromPixelToOffsetCoordinates(int x, int y) => _hex.FromPixelToOffsetCoordinates(x, y);
        public HexOffsetCoordinates RoundOffsetCoordinates(float x, float y) => _hex.RoundOffsetCoordinates(x, y);

        public HexCubeCoordinatesSextuple GetAllNeighbors(HexCubeCoordinates cube) => _hex.GetAllNeighbors(cube);
        public HexCubeCoordinates GetNeighbor(HexCubeCoordinates cube, Direction direction) => _hex.GetNeighbor(cube, direction);
        public HexCubeCoordinates[] GetLine(HexCubeCoordinates fromCube, HexCubeCoordinates toCube) => _hex.GetLine(fromCube, toCube);
        public int GetDistance(HexCubeCoordinates fromCube, HexCubeCoordinates toCube) => _hex.GetDistance(fromCube, toCube);
        public HexCubeCoordinates FromPixelToCubeCoordinates(int x, int y) => _hex.FromPixelToCubeCoordinates(x, y);
        public Point2F FromCubeCoordinatesToPixel(HexCubeCoordinates cube) => _hex.FromCubeCoordinatesToPixel(cube);
        public HexCubeCoordinates RoundCubeCoordinates(float x, float y, float z) => _hex.RoundCubeCoordinates(x, y, z);
        public Point3F Lerp(HexCubeCoordinates fromCube, HexCubeCoordinates toCube, float t) => _hex.Lerp(fromCube, toCube, t);

        public HexAxialCoordinates FromPixelToAxialCoordinates(int x, int y) => _hex.FromPixelToAxialCoordinates(x, y);
        public Point2F FromAxialCoordinatesToPixel(HexAxialCoordinates axial) => _hex.FromAxialCoordinatesToPixel(axial);
        public HexAxialCoordinates RoundAxialCoordinates(float q, float r) => _hex.RoundAxialCoordinates(q, r);

        public Point2FSextuple GetCorners() => _hex.GetCorners();
        public int GetWorldWidthInPixels(int worldMapColumns) => _hex.GetWorldWidthInPixels(worldMapColumns);
        public int GetWorldHeightInPixels(int worldMapRows) => _hex.GetWorldHeightInPixels(worldMapRows);
    }
}