using System.Collections.Generic;

namespace Zen.Hexagons
{
    public interface IHex
    {
        HexType HexType { get; }
        float Size { get; }
        float Width { get; }
        float Height { get; }

        float Apothem { get; }
        float SideToSide { get; }
        float Perimeter { get; }
        float SideLength { get; }
        float CenterToVertex { get; }
        float VertexToVertex { get; }

        HexCubeCoordinates OffsetCoordinatesToCube(HexOffsetCoordinates offset); //
        HexAxialCoordinates OffsetCoordinatesToAxial(HexOffsetCoordinates offset); //
        HexOffsetCoordinates CubeToOffsetCoordinates(HexCubeCoordinates cube);
        HexAxialCoordinates CubeToAxial(HexCubeCoordinates cube);
        HexOffsetCoordinates AxialToOffsetCoordinates(HexAxialCoordinates axial);
        HexCubeCoordinates AxialToCube(HexAxialCoordinates axial);

        HexOffsetCoordinates[] GetAllNeighbors(HexOffsetCoordinates offset); //
        HexOffsetCoordinates GetNeighbor(HexOffsetCoordinates offset, Direction direction); //
        HexOffsetCoordinates[] GetSingleRing(HexOffsetCoordinates offset, int radius); //
        HexOffsetCoordinates[] GetSpiralRing(HexOffsetCoordinates offset, int radius); //
        List<HexOffsetCoordinates> GetLine(HexOffsetCoordinates fromOffset, HexOffsetCoordinates toOffset);
        int GetDistance(HexOffsetCoordinates fromOffset, HexOffsetCoordinates toOffset);
        HexOffsetCoordinates FromPixelToOffsetCoordinates(int x, int y);
        Point2F FromOffsetCoordinatesToPixel(HexOffsetCoordinates offset);
        HexOffsetCoordinates RoundOffsetCoordinates(float x, float y);

        HexCubeCoordinates[] GetAllNeighbors(HexCubeCoordinates cube);
        HexCubeCoordinates GetNeighbor(HexCubeCoordinates cube, Direction direction);
        List<HexCubeCoordinates> GetLine(HexCubeCoordinates fromCube, HexCubeCoordinates toCube);
        int GetDistance(HexCubeCoordinates fromCube, HexCubeCoordinates toCube);
        HexCubeCoordinates FromPixelToCube(int x, int y);
        Point2F FromCubeToPixel(HexCubeCoordinates cube);
        HexCubeCoordinates RoundCube(float x, float y, float z);

        HexAxialCoordinates FromPixelToAxial(int x, int y);
        Point2F FromAxialToPixel(HexAxialCoordinates axial);
        HexAxialCoordinates RoundAxial(float q, float r);

        Point3F Lerp(HexCubeCoordinates fromCube, HexCubeCoordinates toCube, float t);

        Point2F[] GetCorners();

        int GetWorldWidthInPixels(int worldMapColumns);
        int GetWorldHeightInPixels(int worldMapRows);
    }
}