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
        public void GetNeighbor_OddQ()
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
        public void GetNeighbor_EvenQ()
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
        public void GetNeighbor_OddR()
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
        public void GetNeighbor_EvenR()
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

        [Test]
        public void GetSingleRing_OddQ()
        {
            var hexLibrary = new HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Odd, 64.0f);

            var ring1 = hexLibrary.GetSingleRing(new HexOffsetCoordinates(1, 1), 1);

            Assert.AreEqual(6, ring1.Length);
            Assert.AreEqual(new HexOffsetCoordinates(0, 2), ring1[0]);
            Assert.AreEqual(new HexOffsetCoordinates(0, 1), ring1[1]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 0), ring1[2]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 1), ring1[3]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 2), ring1[4]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 2), ring1[5]);

            var ring2 = hexLibrary.GetSingleRing(new HexOffsetCoordinates(2, 2), 2);

            Assert.AreEqual(12, ring2.Length);
            Assert.AreEqual(new HexOffsetCoordinates(0, 3), ring2[0]);
            Assert.AreEqual(new HexOffsetCoordinates(0, 2), ring2[1]);
            Assert.AreEqual(new HexOffsetCoordinates(0, 1), ring2[2]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 0), ring2[3]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 0), ring2[4]);
            Assert.AreEqual(new HexOffsetCoordinates(3, 0), ring2[5]);
            Assert.AreEqual(new HexOffsetCoordinates(4, 1), ring2[6]);
            Assert.AreEqual(new HexOffsetCoordinates(4, 2), ring2[7]);
            Assert.AreEqual(new HexOffsetCoordinates(4, 3), ring2[8]);
            Assert.AreEqual(new HexOffsetCoordinates(3, 3), ring2[9]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 4), ring2[10]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 3), ring2[11]);
        }

        [Test]
        public void GetSingleRing_EvenQ()
        {
            var hexLibrary = new HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Even, 64.0f);

            var ring1 = hexLibrary.GetSingleRing(new HexOffsetCoordinates(1, 1), 1);

            Assert.AreEqual(6, ring1.Length);
            Assert.AreEqual(new HexOffsetCoordinates(0, 1), ring1[0]);
            Assert.AreEqual(new HexOffsetCoordinates(0, 0), ring1[1]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 0), ring1[2]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 0), ring1[3]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 1), ring1[4]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 2), ring1[5]);

            var ring2 = hexLibrary.GetSingleRing(new HexOffsetCoordinates(2, 2), 2);

            Assert.AreEqual(12, ring2.Length);
            Assert.AreEqual(new HexOffsetCoordinates(0, 3), ring2[0]);
            Assert.AreEqual(new HexOffsetCoordinates(0, 2), ring2[1]);
            Assert.AreEqual(new HexOffsetCoordinates(0, 1), ring2[2]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 1), ring2[3]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 0), ring2[4]);
            Assert.AreEqual(new HexOffsetCoordinates(3, 1), ring2[5]);
            Assert.AreEqual(new HexOffsetCoordinates(4, 1), ring2[6]);
            Assert.AreEqual(new HexOffsetCoordinates(4, 2), ring2[7]);
            Assert.AreEqual(new HexOffsetCoordinates(4, 3), ring2[8]);
            Assert.AreEqual(new HexOffsetCoordinates(3, 4), ring2[9]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 4), ring2[10]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 4), ring2[11]);
        }

        [Test]
        public void GetSingleRing_OddR()
        {
            var hexLibrary = new HexLibrary(HexType.PointyTopped, OffsetCoordinatesType.Odd, 64.0f);

            var ring1 = hexLibrary.GetSingleRing(new HexOffsetCoordinates(1, 1), 1);

            Assert.AreEqual(6, ring1.Length);
            Assert.AreEqual(new HexOffsetCoordinates(1, 2), ring1[0]);
            Assert.AreEqual(new HexOffsetCoordinates(0, 1), ring1[1]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 0), ring1[2]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 0), ring1[3]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 1), ring1[4]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 2), ring1[5]);

            var ring2 = hexLibrary.GetSingleRing(new HexOffsetCoordinates(2, 2), 2);

            Assert.AreEqual(12, ring2.Length);
            Assert.AreEqual(new HexOffsetCoordinates(1, 4), ring2[0]);
            Assert.AreEqual(new HexOffsetCoordinates(0, 3), ring2[1]);
            Assert.AreEqual(new HexOffsetCoordinates(0, 2), ring2[2]);
            Assert.AreEqual(new HexOffsetCoordinates(0, 1), ring2[3]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 0), ring2[4]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 0), ring2[5]);
            Assert.AreEqual(new HexOffsetCoordinates(3, 0), ring2[6]);
            Assert.AreEqual(new HexOffsetCoordinates(3, 1), ring2[7]);
            Assert.AreEqual(new HexOffsetCoordinates(4, 2), ring2[8]);
            Assert.AreEqual(new HexOffsetCoordinates(3, 3), ring2[9]);
            Assert.AreEqual(new HexOffsetCoordinates(3, 4), ring2[10]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 4), ring2[11]);
        }

        [Test]
        public void GetSingleRing_EvenR()
        {
            var hexLibrary = new HexLibrary(HexType.PointyTopped, OffsetCoordinatesType.Even, 64.0f);

            var ring1 = hexLibrary.GetSingleRing(new HexOffsetCoordinates(1, 1), 1);

            Assert.AreEqual(6, ring1.Length);
            Assert.AreEqual(new HexOffsetCoordinates(0, 2), ring1[0]);
            Assert.AreEqual(new HexOffsetCoordinates(0, 1), ring1[1]);
            Assert.AreEqual(new HexOffsetCoordinates(0, 0), ring1[2]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 0), ring1[3]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 1), ring1[4]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 2), ring1[5]);

            var ring2 = hexLibrary.GetSingleRing(new HexOffsetCoordinates(2, 2), 2);

            Assert.AreEqual(12, ring2.Length);
            Assert.AreEqual(new HexOffsetCoordinates(1, 4), ring2[0]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 3), ring2[1]);
            Assert.AreEqual(new HexOffsetCoordinates(0, 2), ring2[2]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 1), ring2[3]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 0), ring2[4]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 0), ring2[5]);
            Assert.AreEqual(new HexOffsetCoordinates(3, 0), ring2[6]);
            Assert.AreEqual(new HexOffsetCoordinates(4, 1), ring2[7]);
            Assert.AreEqual(new HexOffsetCoordinates(4, 2), ring2[8]);
            Assert.AreEqual(new HexOffsetCoordinates(4, 3), ring2[9]);
            Assert.AreEqual(new HexOffsetCoordinates(3, 4), ring2[10]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 4), ring2[11]);
        }

        [Test]
        public void GetSpiralRing_OddQ()
        {
            var hexLibrary = new HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Odd, 64.0f);

            var ring1 = hexLibrary.GetSpiralRing(new HexOffsetCoordinates(2, 2), 2);

            Assert.AreEqual(19, ring1.Length);
            Assert.AreEqual(new HexOffsetCoordinates(2, 2), ring1[0]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 2), ring1[1]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 1), ring1[2]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 1), ring1[3]);
            Assert.AreEqual(new HexOffsetCoordinates(3, 1), ring1[4]);
            Assert.AreEqual(new HexOffsetCoordinates(3, 2), ring1[5]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 3), ring1[6]);
            Assert.AreEqual(new HexOffsetCoordinates(0, 3), ring1[7]);
            Assert.AreEqual(new HexOffsetCoordinates(0, 2), ring1[8]);
            Assert.AreEqual(new HexOffsetCoordinates(0, 1), ring1[9]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 0), ring1[10]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 0), ring1[11]);
            Assert.AreEqual(new HexOffsetCoordinates(3, 0), ring1[12]);
            Assert.AreEqual(new HexOffsetCoordinates(4, 1), ring1[13]);
            Assert.AreEqual(new HexOffsetCoordinates(4, 2), ring1[14]);
            Assert.AreEqual(new HexOffsetCoordinates(4, 3), ring1[15]);
            Assert.AreEqual(new HexOffsetCoordinates(3, 3), ring1[16]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 4), ring1[17]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 3), ring1[18]);
        }

        [Test]
        public void GetSpiralRing_EvenQ()
        {
            var hexLibrary = new HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Even, 64.0f);

            var ring1 = hexLibrary.GetSpiralRing(new HexOffsetCoordinates(2, 2), 2);

            Assert.AreEqual(19, ring1.Length);
            Assert.AreEqual(new HexOffsetCoordinates(2, 2), ring1[0]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 3), ring1[1]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 2), ring1[2]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 1), ring1[3]);
            Assert.AreEqual(new HexOffsetCoordinates(3, 2), ring1[4]);
            Assert.AreEqual(new HexOffsetCoordinates(3, 3), ring1[5]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 3), ring1[6]);
            Assert.AreEqual(new HexOffsetCoordinates(0, 3), ring1[7]);
            Assert.AreEqual(new HexOffsetCoordinates(0, 2), ring1[8]);
            Assert.AreEqual(new HexOffsetCoordinates(0, 1), ring1[9]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 1), ring1[10]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 0), ring1[11]);
            Assert.AreEqual(new HexOffsetCoordinates(3, 1), ring1[12]);
            Assert.AreEqual(new HexOffsetCoordinates(4, 1), ring1[13]);
            Assert.AreEqual(new HexOffsetCoordinates(4, 2), ring1[14]);
            Assert.AreEqual(new HexOffsetCoordinates(4, 3), ring1[15]);
            Assert.AreEqual(new HexOffsetCoordinates(3, 4), ring1[16]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 4), ring1[17]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 4), ring1[18]);
        }

        [Test]
        public void GetSpiralRing_OddR()
        {
            var hexLibrary = new HexLibrary(HexType.PointyTopped, OffsetCoordinatesType.Odd, 64.0f);

            var ring1 = hexLibrary.GetSpiralRing(new HexOffsetCoordinates(2, 2), 2);

            Assert.AreEqual(19, ring1.Length);
            Assert.AreEqual(new HexOffsetCoordinates(2, 2), ring1[0]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 3), ring1[1]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 2), ring1[2]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 1), ring1[3]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 1), ring1[4]);
            Assert.AreEqual(new HexOffsetCoordinates(3, 2), ring1[5]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 3), ring1[6]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 4), ring1[7]);
            Assert.AreEqual(new HexOffsetCoordinates(0, 3), ring1[8]);
            Assert.AreEqual(new HexOffsetCoordinates(0, 2), ring1[9]);
            Assert.AreEqual(new HexOffsetCoordinates(0, 1), ring1[10]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 0), ring1[11]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 0), ring1[12]);
            Assert.AreEqual(new HexOffsetCoordinates(3, 0), ring1[13]);
            Assert.AreEqual(new HexOffsetCoordinates(3, 1), ring1[14]);
            Assert.AreEqual(new HexOffsetCoordinates(4, 2), ring1[15]);
            Assert.AreEqual(new HexOffsetCoordinates(3, 3), ring1[16]);
            Assert.AreEqual(new HexOffsetCoordinates(3, 4), ring1[17]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 4), ring1[18]);
        }

        [Test]
        public void GetSpiralRing_EvenR()
        {
            var hexLibrary = new HexLibrary(HexType.PointyTopped, OffsetCoordinatesType.Even, 64.0f);

            var ring1 = hexLibrary.GetSpiralRing(new HexOffsetCoordinates(2, 2), 2);

            Assert.AreEqual(19, ring1.Length);
            Assert.AreEqual(new HexOffsetCoordinates(2, 2), ring1[0]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 3), ring1[1]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 2), ring1[2]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 1), ring1[3]);
            Assert.AreEqual(new HexOffsetCoordinates(3, 1), ring1[4]);
            Assert.AreEqual(new HexOffsetCoordinates(3, 2), ring1[5]);
            Assert.AreEqual(new HexOffsetCoordinates(3, 3), ring1[6]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 4), ring1[7]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 3), ring1[8]);
            Assert.AreEqual(new HexOffsetCoordinates(0, 2), ring1[9]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 1), ring1[10]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 0), ring1[11]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 0), ring1[12]);
            Assert.AreEqual(new HexOffsetCoordinates(3, 0), ring1[13]);
            Assert.AreEqual(new HexOffsetCoordinates(4, 1), ring1[14]);
            Assert.AreEqual(new HexOffsetCoordinates(4, 2), ring1[15]);
            Assert.AreEqual(new HexOffsetCoordinates(4, 3), ring1[16]);
            Assert.AreEqual(new HexOffsetCoordinates(3, 4), ring1[17]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 4), ring1[18]);
        }

        [Test]
        public void GetLine_OddQ()
        {
            var hexLibrary = new HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Odd, 64.0f);

            var line1 = hexLibrary.GetLine(new HexOffsetCoordinates(1, 0), new HexOffsetCoordinates(3, 4));

            Assert.AreEqual(6, line1.Length);
            Assert.AreEqual(new HexOffsetCoordinates(1, 0), line1[0]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 1), line1[1]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 2), line1[2]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 3), line1[3]);
            Assert.AreEqual(new HexOffsetCoordinates(3, 3), line1[4]);
            Assert.AreEqual(new HexOffsetCoordinates(3, 4), line1[5]);
        }

        [Test]
        public void GetLine_EvenQ()
        {
            var hexLibrary = new HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Even, 64.0f);

            var line1 = hexLibrary.GetLine(new HexOffsetCoordinates(1, 0), new HexOffsetCoordinates(3, 4));

            Assert.AreEqual(6, line1.Length);
            Assert.AreEqual(new HexOffsetCoordinates(1, 0), line1[0]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 1), line1[1]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 1), line1[2]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 2), line1[3]);
            Assert.AreEqual(new HexOffsetCoordinates(3, 3), line1[4]);
            Assert.AreEqual(new HexOffsetCoordinates(3, 4), line1[5]);
        }

        [Test]
        public void GetLine_OddR()
        {
            var hexLibrary = new HexLibrary(HexType.PointyTopped, OffsetCoordinatesType.Odd, 64.0f);

            var line1 = hexLibrary.GetLine(new HexOffsetCoordinates(1, 0), new HexOffsetCoordinates(3, 4));

            Assert.AreEqual(5, line1.Length);
            Assert.AreEqual(new HexOffsetCoordinates(1, 0), line1[0]);
            Assert.AreEqual(new HexOffsetCoordinates(1, 1), line1[1]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 2), line1[2]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 3), line1[3]);
            Assert.AreEqual(new HexOffsetCoordinates(3, 4), line1[4]);
        }

        [Test]
        public void GetLine_EvenR()
        {
            var hexLibrary = new HexLibrary(HexType.PointyTopped, OffsetCoordinatesType.Even, 64.0f);

            var line1 = hexLibrary.GetLine(new HexOffsetCoordinates(1, 0), new HexOffsetCoordinates(3, 4));

            Assert.AreEqual(5, line1.Length);
            Assert.AreEqual(new HexOffsetCoordinates(1, 0), line1[0]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 1), line1[1]);
            Assert.AreEqual(new HexOffsetCoordinates(2, 2), line1[2]);
            Assert.AreEqual(new HexOffsetCoordinates(3, 3), line1[3]);
            Assert.AreEqual(new HexOffsetCoordinates(3, 4), line1[4]);
        }

        [Test]
        public void GetDistance_OddQ()
        {
            var hexLibrary = new HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Odd, 64.0f);

            var distance = hexLibrary.GetDistance(new HexOffsetCoordinates(1, 0), new HexOffsetCoordinates(3, 4));

            Assert.AreEqual(5, distance);
        }

        [Test]
        public void GetDistance_EvenQ()
        {
            var hexLibrary = new HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Even, 64.0f);

            var distance = hexLibrary.GetDistance(new HexOffsetCoordinates(1, 0), new HexOffsetCoordinates(3, 4));

            Assert.AreEqual(5, distance);
        }

        [Test]
        public void GetDistance_OddR()
        {
            var hexLibrary = new HexLibrary(HexType.PointyTopped, OffsetCoordinatesType.Odd, 64.0f);

            var distance = hexLibrary.GetDistance(new HexOffsetCoordinates(1, 0), new HexOffsetCoordinates(3, 4));

            Assert.AreEqual(4, distance);
        }

        [Test]
        public void GetDistance_EvenR()
        {
            var hexLibrary = new HexLibrary(HexType.PointyTopped, OffsetCoordinatesType.Even, 64.0f);

            var distance = hexLibrary.GetDistance(new HexOffsetCoordinates(1, 0), new HexOffsetCoordinates(3, 4));

            Assert.AreEqual(4, distance);
        }

        [Test]
        public void FromOffsetCoordinatesToPixel_OddQ()
        {
            var hexLibrary = new HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Odd, 64.0f);

            var pixel00 = hexLibrary.FromOffsetCoordinatesToPixel(new HexOffsetCoordinates(0, 0));
            var pixel01 = hexLibrary.FromOffsetCoordinatesToPixel(new HexOffsetCoordinates(0, 1));
            var pixel10 = hexLibrary.FromOffsetCoordinatesToPixel(new HexOffsetCoordinates(1, 0));
            var pixel11 = hexLibrary.FromOffsetCoordinatesToPixel(new HexOffsetCoordinates(1, 1));

            Assert.AreEqual(new Point2F(0.0f, 0.0f), pixel00);
            Assert.AreEqual(new Point2F(0.0f, 110.85125f), pixel01);
            Assert.AreEqual(new Point2F(96.0f, 55.425625f), pixel10);
            Assert.AreEqual(new Point2F(96.0f, 166.27687f), pixel11);

            hexLibrary = new HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Odd, 64.0f, false);

            pixel00 = hexLibrary.FromOffsetCoordinatesToPixel(new HexOffsetCoordinates(0, 0));
            pixel01 = hexLibrary.FromOffsetCoordinatesToPixel(new HexOffsetCoordinates(0, 1));
            pixel10 = hexLibrary.FromOffsetCoordinatesToPixel(new HexOffsetCoordinates(1, 0));
            pixel11 = hexLibrary.FromOffsetCoordinatesToPixel(new HexOffsetCoordinates(1, 1));

            Assert.AreEqual(new Point2F(64.0f, 55.425625f), pixel00);
            Assert.AreEqual(new Point2F(64.0f, 166.27687f), pixel01);
            Assert.AreEqual(new Point2F(160.0f, 110.85125f), pixel10);
            Assert.AreEqual(new Point2F(160.0f, 221.7025f), pixel11);
        }

        [Test]
        public void FromOffsetCoordinatesToPixel_EvenQ()
        {
            var hexLibrary = new HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Even, 64.0f);

            var pixel00 = hexLibrary.FromOffsetCoordinatesToPixel(new HexOffsetCoordinates(0, 0));
            var pixel01 = hexLibrary.FromOffsetCoordinatesToPixel(new HexOffsetCoordinates(0, 1));
            var pixel10 = hexLibrary.FromOffsetCoordinatesToPixel(new HexOffsetCoordinates(1, 0));
            var pixel11 = hexLibrary.FromOffsetCoordinatesToPixel(new HexOffsetCoordinates(1, 1));

            Assert.AreEqual(new Point2F(0.0f, 0.0f), pixel00);
            Assert.AreEqual(new Point2F(0.0f, 110.85125f), pixel01);
            Assert.AreEqual(new Point2F(96.0f, -55.425625f), pixel10);
            Assert.AreEqual(new Point2F(96.0f, 55.425625f), pixel11);

            hexLibrary = new HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Even, 64.0f, false);

            pixel00 = hexLibrary.FromOffsetCoordinatesToPixel(new HexOffsetCoordinates(0, 0));
            pixel01 = hexLibrary.FromOffsetCoordinatesToPixel(new HexOffsetCoordinates(0, 1));
            pixel10 = hexLibrary.FromOffsetCoordinatesToPixel(new HexOffsetCoordinates(1, 0));
            pixel11 = hexLibrary.FromOffsetCoordinatesToPixel(new HexOffsetCoordinates(1, 1));

            Assert.AreEqual(new Point2F(64.0f, 110.85125f), pixel00);
            Assert.AreEqual(new Point2F(64.0f, 221.7025f), pixel01);
            Assert.AreEqual(new Point2F(160.0f, 55.425625f), pixel10);
            Assert.AreEqual(new Point2F(160.0f, 166.27687f), pixel11);
        }

        [Test]
        public void FromOffsetCoordinatesToPixel_OddR()
        {
            var hexLibrary = new HexLibrary(HexType.PointyTopped, OffsetCoordinatesType.Odd, 64.0f);

            var pixel00 = hexLibrary.FromOffsetCoordinatesToPixel(new HexOffsetCoordinates(0, 0));
            var pixel01 = hexLibrary.FromOffsetCoordinatesToPixel(new HexOffsetCoordinates(0, 1));
            var pixel10 = hexLibrary.FromOffsetCoordinatesToPixel(new HexOffsetCoordinates(1, 0));
            var pixel11 = hexLibrary.FromOffsetCoordinatesToPixel(new HexOffsetCoordinates(1, 1));

            Assert.AreEqual(new Point2F(0.0f, 0.0f), pixel00);
            Assert.AreEqual(new Point2F(55.425625f, 96.0f), pixel01);
            Assert.AreEqual(new Point2F(110.85125f, 0.0f), pixel10);
            Assert.AreEqual(new Point2F(166.27687f, 96.0f), pixel11);

            hexLibrary = new HexLibrary(HexType.PointyTopped, OffsetCoordinatesType.Odd, 64.0f, false);

            pixel00 = hexLibrary.FromOffsetCoordinatesToPixel(new HexOffsetCoordinates(0, 0));
            pixel01 = hexLibrary.FromOffsetCoordinatesToPixel(new HexOffsetCoordinates(0, 1));
            pixel10 = hexLibrary.FromOffsetCoordinatesToPixel(new HexOffsetCoordinates(1, 0));
            pixel11 = hexLibrary.FromOffsetCoordinatesToPixel(new HexOffsetCoordinates(1, 1));

            Assert.AreEqual(new Point2F(55.425625f, 64.0f), pixel00);
            Assert.AreEqual(new Point2F(110.85125f, 160.0f), pixel01);
            Assert.AreEqual(new Point2F(166.27687f, 64.0f), pixel10);
            Assert.AreEqual(new Point2F(221.7025f, 160.0f), pixel11);
        }

        [Test]
        public void FromOffsetCoordinatesToPixel_EvenR()
        {
            var hexLibrary = new HexLibrary(HexType.PointyTopped, OffsetCoordinatesType.Even, 64.0f);

            var pixel00 = hexLibrary.FromOffsetCoordinatesToPixel(new HexOffsetCoordinates(0, 0));
            var pixel01 = hexLibrary.FromOffsetCoordinatesToPixel(new HexOffsetCoordinates(0, 1));
            var pixel10 = hexLibrary.FromOffsetCoordinatesToPixel(new HexOffsetCoordinates(1, 0));
            var pixel11 = hexLibrary.FromOffsetCoordinatesToPixel(new HexOffsetCoordinates(1, 1));

            Assert.AreEqual(new Point2F(0.0f, 0.0f), pixel00);
            Assert.AreEqual(new Point2F(-55.425625f, 96.0f), pixel01);
            Assert.AreEqual(new Point2F(110.85125f, 0.0f), pixel10);
            Assert.AreEqual(new Point2F(55.425625f, 96.0f), pixel11);

            hexLibrary = new HexLibrary(HexType.PointyTopped, OffsetCoordinatesType.Even, 64.0f, false);

            pixel00 = hexLibrary.FromOffsetCoordinatesToPixel(new HexOffsetCoordinates(0, 0));
            pixel01 = hexLibrary.FromOffsetCoordinatesToPixel(new HexOffsetCoordinates(0, 1));
            pixel10 = hexLibrary.FromOffsetCoordinatesToPixel(new HexOffsetCoordinates(1, 0));
            pixel11 = hexLibrary.FromOffsetCoordinatesToPixel(new HexOffsetCoordinates(1, 1));

            Assert.AreEqual(new Point2F(110.85125f, 64.0f), pixel00);
            Assert.AreEqual(new Point2F(55.425625f, 160.0f), pixel01);
            Assert.AreEqual(new Point2F(221.7025f, 64.0f), pixel10);
            Assert.AreEqual(new Point2F(166.27687f, 160.0f), pixel11);
        }

        [Test]
        public void FromPixelToOffsetCoordinates_OddQ()
        {
            var hexLibrary = new HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Odd, 64.0f);

            var offset00 = hexLibrary.FromPixelToOffsetCoordinates(0, 0);
            var offset01 = hexLibrary.FromPixelToOffsetCoordinates(0, 111);
            var offset10 = hexLibrary.FromPixelToOffsetCoordinates(96, 55);
            var offset11 = hexLibrary.FromPixelToOffsetCoordinates(96, 166);

            Assert.AreEqual(new HexOffsetCoordinates(0, 0), offset00);
            Assert.AreEqual(new HexOffsetCoordinates(0, 1), offset01);
            Assert.AreEqual(new HexOffsetCoordinates(1, 0), offset10);
            Assert.AreEqual(new HexOffsetCoordinates(1, 1), offset11);

            hexLibrary = new HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Odd, 64.0f, false);

            offset00 = hexLibrary.FromPixelToOffsetCoordinates(64, 55);
            offset01 = hexLibrary.FromPixelToOffsetCoordinates(64, 111);
            offset10 = hexLibrary.FromPixelToOffsetCoordinates(160, 111);
            offset11 = hexLibrary.FromPixelToOffsetCoordinates(160, 222);

            Assert.AreEqual(new HexOffsetCoordinates(0, 0), offset00);
            Assert.AreEqual(new HexOffsetCoordinates(0, 1), offset01);
            Assert.AreEqual(new HexOffsetCoordinates(1, 0), offset10);
            Assert.AreEqual(new HexOffsetCoordinates(1, 1), offset11);
        }

        [Test]
        public void FromPixelToOffsetCoordinates_EvenQ()
        {
            var hexLibrary = new HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Even, 64.0f);

            var offset00 = hexLibrary.FromPixelToOffsetCoordinates(0, 0);
            var offset01 = hexLibrary.FromPixelToOffsetCoordinates(0, 111);
            var offset10 = hexLibrary.FromPixelToOffsetCoordinates(96, -55);
            var offset11 = hexLibrary.FromPixelToOffsetCoordinates(96, 55);

            Assert.AreEqual(new HexOffsetCoordinates(0, 0), offset00);
            Assert.AreEqual(new HexOffsetCoordinates(0, 1), offset01);
            Assert.AreEqual(new HexOffsetCoordinates(1, 0), offset10);
            Assert.AreEqual(new HexOffsetCoordinates(1, 1), offset11);

            hexLibrary = new HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Even, 64.0f, false);

            offset00 = hexLibrary.FromPixelToOffsetCoordinates(64, 111);
            offset01 = hexLibrary.FromPixelToOffsetCoordinates(64, 222);
            offset10 = hexLibrary.FromPixelToOffsetCoordinates(160, 55);
            offset11 = hexLibrary.FromPixelToOffsetCoordinates(160, 166);

            Assert.AreEqual(new HexOffsetCoordinates(0, 0), offset00);
            Assert.AreEqual(new HexOffsetCoordinates(0, 1), offset01);
            Assert.AreEqual(new HexOffsetCoordinates(1, 0), offset10);
            Assert.AreEqual(new HexOffsetCoordinates(1, 1), offset11);
        }

        [Test]
        public void FromPixelToOffsetCoordinates_OddR()
        {
            var hexLibrary = new HexLibrary(HexType.PointyTopped, OffsetCoordinatesType.Odd, 64.0f);

            var offset00 = hexLibrary.FromPixelToOffsetCoordinates(0, 0);
            var offset01 = hexLibrary.FromPixelToOffsetCoordinates(55, 96);
            var offset10 = hexLibrary.FromPixelToOffsetCoordinates(111, 0);
            var offset11 = hexLibrary.FromPixelToOffsetCoordinates(166, 96);

            Assert.AreEqual(new HexOffsetCoordinates(0, 0), offset00);
            Assert.AreEqual(new HexOffsetCoordinates(0, 1), offset01);
            Assert.AreEqual(new HexOffsetCoordinates(1, 0), offset10);
            Assert.AreEqual(new HexOffsetCoordinates(1, 1), offset11);

            hexLibrary = new HexLibrary(HexType.PointyTopped, OffsetCoordinatesType.Odd, 64.0f, false);

            offset00 = hexLibrary.FromPixelToOffsetCoordinates(55, 64);
            offset01 = hexLibrary.FromPixelToOffsetCoordinates(111, 160);
            offset10 = hexLibrary.FromPixelToOffsetCoordinates(166, 64);
            offset11 = hexLibrary.FromPixelToOffsetCoordinates(222, 160);

            Assert.AreEqual(new HexOffsetCoordinates(0, 0), offset00);
            Assert.AreEqual(new HexOffsetCoordinates(0, 1), offset01);
            Assert.AreEqual(new HexOffsetCoordinates(1, 0), offset10);
            Assert.AreEqual(new HexOffsetCoordinates(1, 1), offset11);
        }

        [Test]
        public void FromPixelToOffsetCoordinates_EvenR()
        {
            var hexLibrary = new HexLibrary(HexType.PointyTopped, OffsetCoordinatesType.Even, 64.0f);

            var offset00 = hexLibrary.FromPixelToOffsetCoordinates(0, 0);
            var offset01 = hexLibrary.FromPixelToOffsetCoordinates(-55, 96);
            var offset10 = hexLibrary.FromPixelToOffsetCoordinates(110, 0);
            var offset11 = hexLibrary.FromPixelToOffsetCoordinates(55, 96);

            Assert.AreEqual(new HexOffsetCoordinates(0, 0), offset00);
            Assert.AreEqual(new HexOffsetCoordinates(0, 1), offset01);
            Assert.AreEqual(new HexOffsetCoordinates(1, 0), offset10);
            Assert.AreEqual(new HexOffsetCoordinates(1, 1), offset11);

            hexLibrary = new HexLibrary(HexType.PointyTopped, OffsetCoordinatesType.Even, 64.0f, false);

            offset00 = hexLibrary.FromPixelToOffsetCoordinates(111, 64);
            offset01 = hexLibrary.FromPixelToOffsetCoordinates(55, 160);
            offset10 = hexLibrary.FromPixelToOffsetCoordinates(222, 64);
            offset11 = hexLibrary.FromPixelToOffsetCoordinates(166, 160);

            Assert.AreEqual(new HexOffsetCoordinates(0, 0), offset00);
            Assert.AreEqual(new HexOffsetCoordinates(0, 1), offset01);
            Assert.AreEqual(new HexOffsetCoordinates(1, 0), offset10);
            Assert.AreEqual(new HexOffsetCoordinates(1, 1), offset11);
        }

        [Test]
        public void RoundOffsetCoordinates_OddQ()
        {
            var hexLibrary = new HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Odd, 64.0f);

            var offset00 = hexLibrary.RoundOffsetCoordinates(0.3f, 0.3f);
            var offset01 = hexLibrary.RoundOffsetCoordinates(0.3f, 0.8f);
            var offset10 = hexLibrary.RoundOffsetCoordinates(0.8f, 0.3f);
            var offset11 = hexLibrary.RoundOffsetCoordinates(0.8f, 0.8f);

            Assert.AreEqual(new HexOffsetCoordinates(0, 0), offset00);
            Assert.AreEqual(new HexOffsetCoordinates(0, 1), offset01);
            Assert.AreEqual(new HexOffsetCoordinates(1, 0), offset10);
            Assert.AreEqual(new HexOffsetCoordinates(1, 1), offset11);
        }

        [Test]
        public void RoundOffsetCoordinates_EvenQ()
        {
            var hexLibrary = new HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Even, 64.0f);

            var offset00 = hexLibrary.RoundOffsetCoordinates(0.3f, 0.3f);
            var offset01 = hexLibrary.RoundOffsetCoordinates(0.3f, 0.8f);
            var offset11 = hexLibrary.RoundOffsetCoordinates(0.8f, 0.3f);
            var offset12 = hexLibrary.RoundOffsetCoordinates(0.8f, 0.8f);

            Assert.AreEqual(new HexOffsetCoordinates(0, 0), offset00);
            Assert.AreEqual(new HexOffsetCoordinates(0, 1), offset01);
            Assert.AreEqual(new HexOffsetCoordinates(1, 1), offset11);
            Assert.AreEqual(new HexOffsetCoordinates(1, 2), offset12);
        }

        [Test]
        public void RoundOffsetCoordinates_OddR()
        {
            var hexLibrary = new HexLibrary(HexType.PointyTopped, OffsetCoordinatesType.Odd, 64.0f);

            var offset00 = hexLibrary.RoundOffsetCoordinates(0.3f, 0.3f);
            var offset01 = hexLibrary.RoundOffsetCoordinates(0.3f, 0.8f);
            var offset10 = hexLibrary.RoundOffsetCoordinates(0.8f, 0.3f);
            var offset11 = hexLibrary.RoundOffsetCoordinates(0.8f, 0.8f);

            Assert.AreEqual(new HexOffsetCoordinates(0, 0), offset00);
            Assert.AreEqual(new HexOffsetCoordinates(0, 1), offset01);
            Assert.AreEqual(new HexOffsetCoordinates(1, 0), offset10);
            Assert.AreEqual(new HexOffsetCoordinates(1, 1), offset11);
        }

        [Test]
        public void RoundOffsetCoordinates_EvenR()
        {
            var hexLibrary = new HexLibrary(HexType.PointyTopped, OffsetCoordinatesType.Even, 64.0f);

            var offset00 = hexLibrary.RoundOffsetCoordinates(0.3f, 0.3f);
            var offset11 = hexLibrary.RoundOffsetCoordinates(0.3f, 0.8f);
            var offset10 = hexLibrary.RoundOffsetCoordinates(0.8f, 0.3f);
            var offset21 = hexLibrary.RoundOffsetCoordinates(0.8f, 0.8f);

            Assert.AreEqual(new HexOffsetCoordinates(0, 0), offset00);
            Assert.AreEqual(new HexOffsetCoordinates(1, 1), offset11);
            Assert.AreEqual(new HexOffsetCoordinates(1, 0), offset10);
            Assert.AreEqual(new HexOffsetCoordinates(2, 1), offset21);
        }
    }
}