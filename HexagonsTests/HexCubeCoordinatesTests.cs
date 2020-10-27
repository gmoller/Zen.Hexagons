using NUnit.Framework;
using Zen.Hexagons;

namespace Zen.HexagonsTests
{
    public class HexCubeCoordinatesTests
    {
        [Test]
        public void GetAllNeighbors_Q()
        {
            var hexLibrary = new HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Odd, 64.0f);

            var neighbors = hexLibrary.GetAllNeighbors(new HexCubeCoordinates(0, 0, 0));

            Assert.AreEqual(new HexCubeCoordinates(0, 1, -1), neighbors.HexCubeCoordinates0);
            Assert.AreEqual(new HexCubeCoordinates(1, 0, -1), neighbors.HexCubeCoordinates1);
            Assert.AreEqual(new HexCubeCoordinates(1, -1, 0), neighbors.HexCubeCoordinates2);
            Assert.AreEqual(new HexCubeCoordinates(0, -1, 1), neighbors.HexCubeCoordinates3);
            Assert.AreEqual(new HexCubeCoordinates(-1, 0, 1), neighbors.HexCubeCoordinates4);
            Assert.AreEqual(new HexCubeCoordinates(-1, 1, 0), neighbors.HexCubeCoordinates5);
        }

        [Test]
        public void GetAllNeighbors_R()
        {
            var hexLibrary = new HexLibrary(HexType.PointyTopped, OffsetCoordinatesType.Odd, 64.0f);

            var neighbors = hexLibrary.GetAllNeighbors(new HexCubeCoordinates(0, 0, 0));

            Assert.AreEqual(new HexCubeCoordinates(1, 0, -1), neighbors.HexCubeCoordinates0);
            Assert.AreEqual(new HexCubeCoordinates(1, -1, 0), neighbors.HexCubeCoordinates1);
            Assert.AreEqual(new HexCubeCoordinates(0, -1, 1), neighbors.HexCubeCoordinates2);
            Assert.AreEqual(new HexCubeCoordinates(-1, 0, 1), neighbors.HexCubeCoordinates3);
            Assert.AreEqual(new HexCubeCoordinates(-1, 1, 0), neighbors.HexCubeCoordinates4);
            Assert.AreEqual(new HexCubeCoordinates(0, 1, -1), neighbors.HexCubeCoordinates5);
        }

        [Test]
        public void GetNeighbor_Q()
        {
            var hexLibrary = new HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Odd, 64.0f);

            var neighborN = hexLibrary.GetNeighbor(new HexCubeCoordinates(0, 0, 0), Direction.North);
            var neighborNE = hexLibrary.GetNeighbor(new HexCubeCoordinates(0, 0, 0), Direction.NorthEast);
            var neighborSE = hexLibrary.GetNeighbor(new HexCubeCoordinates(0, 0, 0), Direction.SouthEast);
            var neighborS = hexLibrary.GetNeighbor(new HexCubeCoordinates(0, 0, 0), Direction.South);
            var neighborSW = hexLibrary.GetNeighbor(new HexCubeCoordinates(0, 0, 0), Direction.SouthWest);
            var neighborNW = hexLibrary.GetNeighbor(new HexCubeCoordinates(0, 0, 0), Direction.NorthWest);

            Assert.AreEqual(new HexCubeCoordinates(0, 1, -1), neighborN);
            Assert.AreEqual(new HexCubeCoordinates(1, 0, -1), neighborNE);
            Assert.AreEqual(new HexCubeCoordinates(1, -1, 0), neighborSE);
            Assert.AreEqual(new HexCubeCoordinates(0, -1, 1), neighborS);
            Assert.AreEqual(new HexCubeCoordinates(-1, 0, 1), neighborSW);
            Assert.AreEqual(new HexCubeCoordinates(-1, 1, 0), neighborNW);
        }

        [Test]
        public void GetNeighbor_R()
        {
            var hexLibrary = new HexLibrary(HexType.PointyTopped, OffsetCoordinatesType.Odd, 64.0f);

            var neighborNE = hexLibrary.GetNeighbor(new HexCubeCoordinates(0, 0, 0), Direction.NorthEast);
            var neighborE = hexLibrary.GetNeighbor(new HexCubeCoordinates(0, 0, 0), Direction.East);
            var neighborSE = hexLibrary.GetNeighbor(new HexCubeCoordinates(0, 0, 0), Direction.SouthEast);
            var neighborSW = hexLibrary.GetNeighbor(new HexCubeCoordinates(0, 0, 0), Direction.SouthWest);
            var neighborW = hexLibrary.GetNeighbor(new HexCubeCoordinates(0, 0, 0), Direction.West);
            var neighborNW = hexLibrary.GetNeighbor(new HexCubeCoordinates(0, 0, 0), Direction.NorthWest);

            Assert.AreEqual(new HexCubeCoordinates(1, 0, -1), neighborNE);
            Assert.AreEqual(new HexCubeCoordinates(1, -1, 0), neighborE);
            Assert.AreEqual(new HexCubeCoordinates(0, -1, 1), neighborSE);
            Assert.AreEqual(new HexCubeCoordinates(-1, 0, 1), neighborSW);
            Assert.AreEqual(new HexCubeCoordinates(-1, 1, 0), neighborW);
            Assert.AreEqual(new HexCubeCoordinates(0, 1, -1), neighborNW);
        }
    }
}