using System.Collections.Generic;

namespace Zen.Hexagons
{
    public interface IHex
    {
        HexType HexType { get; set; }
        float Size { get; set; }
        float VertexToVertex { get; set; }
        float SideToSide { get; set; }
        float Apothem { get; set; }
        float SideLength { get; set; }

        HexCube OffsetCoordinatesToCube(HexOffsetCoordinates hexOffsetCoordinates); //
        HexAxial OffsetCoordinatesToAxial(HexOffsetCoordinates offsetCoordinates); //
        HexOffsetCoordinates CubeToOffsetCoordinates(HexCube hexCube);
        HexAxial CubeToAxial(HexCube hexCube);
        HexOffsetCoordinates AxialToOffsetCoordinates(HexAxial hexAxial);
        HexCube AxialToCube(HexAxial hexAxial);

        HexOffsetCoordinates[] GetAllNeighbors(HexOffsetCoordinates hexOffsetCoordinates); //
        HexOffsetCoordinates GetNeighbor(HexOffsetCoordinates hexOffsetCoordinates, Direction direction); //
        HexOffsetCoordinates[] GetSingleRing(HexOffsetCoordinates offsetCoordinates, int radius);
        HexOffsetCoordinates[] GetSpiralRing(HexOffsetCoordinates offsetCoordinates, int radius);
        List<HexOffsetCoordinates> GetLine(HexOffsetCoordinates fromOffsetCoordinates, HexOffsetCoordinates toOffsetCoordinates);
        int GetDistance(HexOffsetCoordinates from, HexOffsetCoordinates to);
        HexOffsetCoordinates FromPixelToOffsetCoordinates(int x, int y);
        Point2F FromOffsetCoordinatesToPixel(HexOffsetCoordinates offsetCoordinates);
        HexOffsetCoordinates RoundOffsetCoordinates(float x, float y);

        HexCube[] GetAllNeighbors(HexCube hexCube);
        HexCube GetNeighbor(HexCube hexCube, Direction direction);
        List<HexCube> GetLine(HexCube fromCube, HexCube toCube);
        int GetDistance(HexCube fromCube, HexCube toCube);
        HexCube FromPixelToCube(int x, int y);
        Point2F FromCubeToPixel(HexCube cube);
        HexCube RoundCube(float x, float y, float z);

        HexAxial FromPixelToAxial(int x, int y);
        Point2F FromAxialToPixel(HexAxial axial);
        HexAxial RoundAxial(float q, float r);

        Point3F Lerp(HexCube a, HexCube b, float t);

        Point2F[] GetCorners();

        int GetHexWidth();
        int GetHexHeight();
        int GetWorldWidthInPixels(int worldMapColumns);
        int GetWorldHeightInPixels(int worldMapRows);
    }
}