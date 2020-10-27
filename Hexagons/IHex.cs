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

        HexCubeCoordinates OffsetToCubeCoordinates(HexOffsetCoordinates offset); //
        HexAxialCoordinates OffsetToAxialCoordinates(HexOffsetCoordinates offset); //
        HexOffsetCoordinates CubeToOffsetCoordinates(HexCubeCoordinates cube); //
        HexAxialCoordinates CubeToAxialCoordinates(HexCubeCoordinates cube); //
        HexOffsetCoordinates AxialToOffsetCoordinates(HexAxialCoordinates axial); //
        HexCubeCoordinates AxialToCubeCoordinates(HexAxialCoordinates axial); //

        HexOffsetCoordinatesSextuple GetAllNeighbors(HexOffsetCoordinates offset); //
        HexOffsetCoordinates GetNeighbor(HexOffsetCoordinates offset, Direction direction); //
        HexOffsetCoordinates[] GetSingleRing(HexOffsetCoordinates offset, int radius); //
        HexOffsetCoordinates[] GetSpiralRing(HexOffsetCoordinates offset, int radius); //
        HexOffsetCoordinates[] GetLine(HexOffsetCoordinates fromOffset, HexOffsetCoordinates toOffset); //
        int GetDistance(HexOffsetCoordinates fromOffset, HexOffsetCoordinates toOffset); //
        Point2F FromOffsetCoordinatesToPixel(HexOffsetCoordinates offset); //
        HexOffsetCoordinates FromPixelToOffsetCoordinates(int x, int y); //
        HexOffsetCoordinates RoundOffsetCoordinates(float x, float y); //

        HexCubeCoordinatesSextuple GetAllNeighbors(HexCubeCoordinates cube); //
        HexCubeCoordinates GetNeighbor(HexCubeCoordinates cube, Direction direction); //
        //HexCubeCoordinates[] GetSingleRing(HexCubeCoordinates offset, int radius);
        //HexCubeCoordinates[] GetSpiralRing(HexCubeCoordinates offset, int radius);
        HexCubeCoordinates[] GetLine(HexCubeCoordinates fromCube, HexCubeCoordinates toCube);
        int GetDistance(HexCubeCoordinates fromCube, HexCubeCoordinates toCube);
        HexCubeCoordinates FromPixelToCubeCoordinates(int x, int y);
        Point2F FromCubeCoordinatesToPixel(HexCubeCoordinates cube);
        HexCubeCoordinates RoundCubeCoordinates(float x, float y, float z);
        Point3F Lerp(HexCubeCoordinates fromCube, HexCubeCoordinates toCube, float t);

        //HexAxialCoordinates[] GetAllNeighbors(HexAxialCoordinates offset);
        //HexAxialCoordinates GetNeighbor(HexAxialCoordinates offset, Direction direction);
        //HexAxialCoordinates[] GetSingleRing(HexAxialCoordinates offset, int radius);
        //HexAxialCoordinates[] GetSpiralRing(HexAxialCoordinates offset, int radius);
        //HexAxialCoordinates[] GetLine(HexAxialCoordinates fromOffset, HexAxialCoordinates toOffset);
        //int GetDistance(HexAxialCoordinates fromOffset, HexAxialCoordinates toOffset);
        HexAxialCoordinates FromPixelToAxialCoordinates(int x, int y);
        Point2F FromAxialCoordinatesToPixel(HexAxialCoordinates axial);
        HexAxialCoordinates RoundAxialCoordinates(float q, float r);
        //Point3F Lerp(HexAxialCoordinates fromAxial, HexAxialCoordinates toAxial, float t);

        Point2FSextuple GetCorners();

        int GetWorldWidthInPixels(int worldMapColumns);
        int GetWorldHeightInPixels(int worldMapRows);
    }
}