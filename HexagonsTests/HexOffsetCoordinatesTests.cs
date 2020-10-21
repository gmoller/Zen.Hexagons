using NUnit.Framework;
using Zen.Hexagons;

namespace Zen.HexagonsTests
{
    public class HexOffsetCoordinatesTests
    {
        [Test]
        public void GetAllNeighbors_OddQ()
        {
            var hexLibrary = new HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Odd, 64.0f);

            var neighbors = hexLibrary.GetAllNeighbors(new HexOffsetCoordinates(1, 1));

            Assert.AreEqual(6, neighbors.Length);
            Assert.AreEqual(new HexOffsetCoordinates(1, 0), neighbors[0]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 1), neighbors[1]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 2), neighbors[2]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 2), neighbors[3]);
            Assert.AreEqual(new HexOffsetCoordinates(0, 2), neighbors[4]);
            Assert.AreEqual(new HexOffsetCoordinates(0, 1), neighbors[5]);
        }

        [Test]
        public void GetAllNeighbors_EvenQ()
        {
            var hexLibrary = new HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Even, 64.0f);

            var neighbors = hexLibrary.GetAllNeighbors(new HexOffsetCoordinates(1, 1));

            Assert.AreEqual(6, neighbors.Length);
            Assert.AreEqual(new HexOffsetCoordinates(1, 0), neighbors[0]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 0), neighbors[1]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 1), neighbors[2]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 2), neighbors[3]);
            Assert.AreEqual(new HexOffsetCoordinates(0, 1), neighbors[4]);
            Assert.AreEqual(new HexOffsetCoordinates(0, 0), neighbors[5]);
        }

        [Test]
        public void GetAllNeighbors_OddR()
        {
            var hexLibrary = new HexLibrary(HexType.PointyTopped, OffsetCoordinatesType.Odd, 64.0f);

            var neighbors = hexLibrary.GetAllNeighbors(new HexOffsetCoordinates(1, 1));

            Assert.AreEqual(6, neighbors.Length);
            Assert.AreEqual(new HexOffsetCoordinates(2, 0), neighbors[0]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 1), neighbors[1]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 2), neighbors[2]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 2), neighbors[3]);
            Assert.AreEqual(new HexOffsetCoordinates(0, 1), neighbors[4]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 0), neighbors[5]);
        }

        [Test]
        public void GetAllNeighbors_EvenR()
        {
            var hexLibrary = new HexLibrary(HexType.PointyTopped, OffsetCoordinatesType.Even, 64.0f);

            var neighbors = hexLibrary.GetAllNeighbors(new HexOffsetCoordinates(1, 1));

            Assert.AreEqual(6, neighbors.Length);
            Assert.AreEqual(new HexOffsetCoordinates(1, 0), neighbors[0]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 1), neighbors[1]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 2), neighbors[2]);
            Assert.AreEqual(new HexOffsetCoordinates(0, 2), neighbors[3]);
            Assert.AreEqual(new HexOffsetCoordinates(0, 1), neighbors[4]);
            Assert.AreEqual(new HexOffsetCoordinates(0, 0), neighbors[5]);
        }

        [Test]
        public void GetAllNeighbor_OddQ()
        {
            var hexLibrary = new HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Odd, 64.0f);

            var neighborN = hexLibrary.GetNeighbor(new HexOffsetCoordinates(1, 1), Direction.North);
            var neighborNE = hexLibrary.GetNeighbor(new HexOffsetCoordinates(1, 1), Direction.NorthEast);
            var neighborSE = hexLibrary.GetNeighbor(new HexOffsetCoordinates(1, 1), Direction.SouthEast);
            var neighborS = hexLibrary.GetNeighbor(new HexOffsetCoordinates(1, 1), Direction.South);
            var neighborSW = hexLibrary.GetNeighbor(new HexOffsetCoordinates(1, 1), Direction.SouthWest);
            var neighborNW = hexLibrary.GetNeighbor(new HexOffsetCoordinates(1, 1), Direction.NorthWest);

            Assert.AreEqual(new HexOffsetCoordinates(1, 0), neighborN);
            Assert.AreEqual(new HexOffsetCoordinates(2, 1), neighborNE);
            Assert.AreEqual(new HexOffsetCoordinates(2, 2), neighborSE);
            Assert.AreEqual(new HexOffsetCoordinates(1, 2), neighborS);
            Assert.AreEqual(new HexOffsetCoordinates(0, 2), neighborSW);
            Assert.AreEqual(new HexOffsetCoordinates(0, 1), neighborNW);
        }

        [Test]
        public void GetAllNeighbor_EvenQ()
        {
            var hexLibrary = new HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Even, 64.0f);

            var neighborN = hexLibrary.GetNeighbor(new HexOffsetCoordinates(1, 1), Direction.North);
            var neighborNE = hexLibrary.GetNeighbor(new HexOffsetCoordinates(1, 1), Direction.NorthEast);
            var neighborSE = hexLibrary.GetNeighbor(new HexOffsetCoordinates(1, 1), Direction.SouthEast);
            var neighborS = hexLibrary.GetNeighbor(new HexOffsetCoordinates(1, 1), Direction.South);
            var neighborSW = hexLibrary.GetNeighbor(new HexOffsetCoordinates(1, 1), Direction.SouthWest);
            var neighborNW = hexLibrary.GetNeighbor(new HexOffsetCoordinates(1, 1), Direction.NorthWest);

            Assert.AreEqual(new HexOffsetCoordinates(1, 0), neighborN);
            Assert.AreEqual(new HexOffsetCoordinates(2, 0), neighborNE);
            Assert.AreEqual(new HexOffsetCoordinates(2, 1), neighborSE);
            Assert.AreEqual(new HexOffsetCoordinates(1, 2), neighborS);
            Assert.AreEqual(new HexOffsetCoordinates(0, 1), neighborSW);
            Assert.AreEqual(new HexOffsetCoordinates(0, 0), neighborNW);
        }

        [Test]
        public void GetAllNeighbor_OddR()
        {
            var hexLibrary = new HexLibrary(HexType.PointyTopped, OffsetCoordinatesType.Odd, 64.0f);

            var neighborNE = hexLibrary.GetNeighbor(new HexOffsetCoordinates(1, 1), Direction.NorthEast);
            var neighborE = hexLibrary.GetNeighbor(new HexOffsetCoordinates(1, 1), Direction.East);
            var neighborSE = hexLibrary.GetNeighbor(new HexOffsetCoordinates(1, 1), Direction.SouthEast);
            var neighborSW = hexLibrary.GetNeighbor(new HexOffsetCoordinates(1, 1), Direction.SouthWest);
            var neighborW = hexLibrary.GetNeighbor(new HexOffsetCoordinates(1, 1), Direction.West);
            var neighborNW = hexLibrary.GetNeighbor(new HexOffsetCoordinates(1, 1), Direction.NorthWest);

            Assert.AreEqual(new HexOffsetCoordinates(2, 0), neighborNE);
            Assert.AreEqual(new HexOffsetCoordinates(2, 1), neighborE);
            Assert.AreEqual(new HexOffsetCoordinates(2, 2), neighborSE);
            Assert.AreEqual(new HexOffsetCoordinates(1, 2), neighborSW);
            Assert.AreEqual(new HexOffsetCoordinates(0, 1), neighborW);
            Assert.AreEqual(new HexOffsetCoordinates(1, 0), neighborNW);
        }

        [Test]
        public void GetAllNeighbor_EvenR()
        {
            var hexLibrary = new HexLibrary(HexType.PointyTopped, OffsetCoordinatesType.Even, 64.0f);

            var neighborNE = hexLibrary.GetNeighbor(new HexOffsetCoordinates(1, 1), Direction.NorthEast);
            var neighborE = hexLibrary.GetNeighbor(new HexOffsetCoordinates(1, 1), Direction.East);
            var neighborSE = hexLibrary.GetNeighbor(new HexOffsetCoordinates(1, 1), Direction.SouthEast);
            var neighborSW = hexLibrary.GetNeighbor(new HexOffsetCoordinates(1, 1), Direction.SouthWest);
            var neighborW = hexLibrary.GetNeighbor(new HexOffsetCoordinates(1, 1), Direction.West);
            var neighborNW = hexLibrary.GetNeighbor(new HexOffsetCoordinates(1, 1), Direction.NorthWest);

            Assert.AreEqual(new HexOffsetCoordinates(1, 0), neighborNE);
            Assert.AreEqual(new HexOffsetCoordinates(2, 1), neighborE);
            Assert.AreEqual(new HexOffsetCoordinates(1, 2), neighborSE);
            Assert.AreEqual(new HexOffsetCoordinates(0, 2), neighborSW);
            Assert.AreEqual(new HexOffsetCoordinates(0, 1), neighborW);
            Assert.AreEqual(new HexOffsetCoordinates(0, 0), neighborNW);
        }
    }
}