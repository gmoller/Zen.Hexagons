using NUnit.Framework;
using Zen.Hexagons;

namespace Zen.HexagonsTests
{
    public class ConversionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void OffsetToCubeCoordinates_OddQ()
        {
            var hexLibrary = new HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Odd, 64.0f);

            var cube1 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-2, -2));
            var cube2 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-1, -2));
            var cube3 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(0, -2));
            var cube4 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(1, -2));
            var cube5 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(2, -2));
            var cube6 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-2, -1));
            var cube7 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-1, -1));
            var cube8 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(0, -1));
            var cube9 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(1, -1));
            var cube10 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(2, -1));
            var cube11 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-2, 0));
            var cube12 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-1, 0));
            var cube13 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(0, 0));
            var cube14 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(1, 0));
            var cube15 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(2, 0));
            var cube16 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-2, 1));
            var cube17 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-1, 1));
            var cube18 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(0, 1));
            var cube19 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(1, 1));
            var cube20 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(2, 1));
            var cube21 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-2, 2));
            var cube22 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-1, 2));
            var cube23 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(0, 2));
            var cube24 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(1, 2));
            var cube25 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(2, 2));

            Assert.AreEqual(new HexCubeCoordinates(-2, 3, -1), cube1);
            Assert.AreEqual(new HexCubeCoordinates(-1, 2, -1), cube2);
            Assert.AreEqual(new HexCubeCoordinates(0, 2, -2), cube3);
            Assert.AreEqual(new HexCubeCoordinates(1, 1, -2), cube4);
            Assert.AreEqual(new HexCubeCoordinates(2, 1, -3), cube5);
            Assert.AreEqual(new HexCubeCoordinates(-2, 2, 0), cube6);
            Assert.AreEqual(new HexCubeCoordinates(-1, 1, 0), cube7);
            Assert.AreEqual(new HexCubeCoordinates(0, 1, -1), cube8);
            Assert.AreEqual(new HexCubeCoordinates(1, 0, -1), cube9);
            Assert.AreEqual(new HexCubeCoordinates(2, 0, -2), cube10);
            Assert.AreEqual(new HexCubeCoordinates(-2, 1, 1), cube11);
            Assert.AreEqual(new HexCubeCoordinates(-1, 0, 1), cube12);
            Assert.AreEqual(new HexCubeCoordinates(0, 0, 0), cube13);
            Assert.AreEqual(new HexCubeCoordinates(1, -1, 0), cube14);
            Assert.AreEqual(new HexCubeCoordinates(2, -1, -1), cube15);
            Assert.AreEqual(new HexCubeCoordinates(-2, 0, 2), cube16);
            Assert.AreEqual(new HexCubeCoordinates(-1, -1, 2), cube17);
            Assert.AreEqual(new HexCubeCoordinates(0, -1, 1), cube18);
            Assert.AreEqual(new HexCubeCoordinates(1, -2, 1), cube19);
            Assert.AreEqual(new HexCubeCoordinates(2, -2, 0), cube20);
            Assert.AreEqual(new HexCubeCoordinates(-2, -1, 3), cube21);
            Assert.AreEqual(new HexCubeCoordinates(-1, -2, 3), cube22);
            Assert.AreEqual(new HexCubeCoordinates(0, -2, 2), cube23);
            Assert.AreEqual(new HexCubeCoordinates(1, -3, 2), cube24);
            Assert.AreEqual(new HexCubeCoordinates(2, -3, 1), cube25);
        }

        [Test]
        public void OffsetToCubeCoordinates_EvenQ()
        {
            var hexLibrary = new HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Even, 64.0f);

            var cube1 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-2, -2));
            var cube2 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-1, -2));
            var cube3 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(0, -2));
            var cube4 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(1, -2));
            var cube5 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(2, -2));
            var cube6 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-2, -1));
            var cube7 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-1, -1));
            var cube8 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(0, -1));
            var cube9 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(1, -1));
            var cube10 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(2, -1));
            var cube11 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-2, 0));
            var cube12 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-1, 0));
            var cube13 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(0, 0));
            var cube14 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(1, 0));
            var cube15 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(2, 0));
            var cube16 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-2, 1));
            var cube17 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-1, 1));
            var cube18 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(0, 1));
            var cube19 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(1, 1));
            var cube20 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(2, 1));
            var cube21 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-2, 2));
            var cube22 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-1, 2));
            var cube23 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(0, 2));
            var cube24 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(1, 2));
            var cube25 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(2, 2));

            Assert.AreEqual(new HexCubeCoordinates(-2, 3, -1), cube1);
            Assert.AreEqual(new HexCubeCoordinates(-1, 3, -2), cube2);
            Assert.AreEqual(new HexCubeCoordinates(0, 2, -2), cube3);
            Assert.AreEqual(new HexCubeCoordinates(1, 2, -3), cube4);
            Assert.AreEqual(new HexCubeCoordinates(2, 1, -3), cube5);
            Assert.AreEqual(new HexCubeCoordinates(-2, 2, 0), cube6);
            Assert.AreEqual(new HexCubeCoordinates(-1, 2, -1), cube7);
            Assert.AreEqual(new HexCubeCoordinates(0, 1, -1), cube8);
            Assert.AreEqual(new HexCubeCoordinates(1, 1, -2), cube9);
            Assert.AreEqual(new HexCubeCoordinates(2, 0, -2), cube10);
            Assert.AreEqual(new HexCubeCoordinates(-2, 1, 1), cube11);
            Assert.AreEqual(new HexCubeCoordinates(-1, 1, 0), cube12);
            Assert.AreEqual(new HexCubeCoordinates(0, 0, 0), cube13);
            Assert.AreEqual(new HexCubeCoordinates(1, 0, -1), cube14);
            Assert.AreEqual(new HexCubeCoordinates(2, -1, -1), cube15);
            Assert.AreEqual(new HexCubeCoordinates(-2, 0, 2), cube16);
            Assert.AreEqual(new HexCubeCoordinates(-1, 0, 1), cube17);
            Assert.AreEqual(new HexCubeCoordinates(0, -1, 1), cube18);
            Assert.AreEqual(new HexCubeCoordinates(1, -1, 0), cube19);
            Assert.AreEqual(new HexCubeCoordinates(2, -2, 0), cube20);
            Assert.AreEqual(new HexCubeCoordinates(-2, -1, 3), cube21);
            Assert.AreEqual(new HexCubeCoordinates(-1, -1, 2), cube22);
            Assert.AreEqual(new HexCubeCoordinates(0, -2, 2), cube23);
            Assert.AreEqual(new HexCubeCoordinates(1, -2, 1), cube24);
            Assert.AreEqual(new HexCubeCoordinates(2, -3, 1), cube25);
        }

        [Test]
        public void OffsetToCubeCoordinates_OddR()
        {
            var hexLibrary = new HexLibrary(HexType.PointyTopped, OffsetCoordinatesType.Odd, 64.0f);

            var cube1 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-2, -2));
            var cube2 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-1, -2));
            var cube3 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(0, -2));
            var cube4 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(1, -2));
            var cube5 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(2, -2));
            var cube6 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-2, -1));
            var cube7 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-1, -1));
            var cube8 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(0, -1));
            var cube9 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(1, -1));
            var cube10 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(2, -1));
            var cube11 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-2, 0));
            var cube12 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-1, 0));
            var cube13 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(0, 0));
            var cube14 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(1, 0));
            var cube15 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(2, 0));
            var cube16 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-2, 1));
            var cube17 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-1, 1));
            var cube18 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(0, 1));
            var cube19 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(1, 1));
            var cube20 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(2, 1));
            var cube21 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-2, 2));
            var cube22 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-1, 2));
            var cube23 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(0, 2));
            var cube24 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(1, 2));
            var cube25 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(2, 2));

            Assert.AreEqual(new HexCubeCoordinates(-1, 3, -2), cube1);
            Assert.AreEqual(new HexCubeCoordinates(0, 2, -2), cube2);
            Assert.AreEqual(new HexCubeCoordinates(1, 1, -2), cube3);
            Assert.AreEqual(new HexCubeCoordinates(2, 0, -2), cube4);
            Assert.AreEqual(new HexCubeCoordinates(3, -1, -2), cube5);
            Assert.AreEqual(new HexCubeCoordinates(-1, 2, -1), cube6);
            Assert.AreEqual(new HexCubeCoordinates(0, 1, -1), cube7);
            Assert.AreEqual(new HexCubeCoordinates(1, 0, -1), cube8);
            Assert.AreEqual(new HexCubeCoordinates(2, -1, -1), cube9);
            Assert.AreEqual(new HexCubeCoordinates(3, -2, -1), cube10);
            Assert.AreEqual(new HexCubeCoordinates(-2, 2, 0), cube11);
            Assert.AreEqual(new HexCubeCoordinates(-1, 1, 0), cube12);
            Assert.AreEqual(new HexCubeCoordinates(0, 0, 0), cube13);
            Assert.AreEqual(new HexCubeCoordinates(1, -1, 0), cube14);
            Assert.AreEqual(new HexCubeCoordinates(2, -2, 0), cube15);
            Assert.AreEqual(new HexCubeCoordinates(-2, 1, 1), cube16);
            Assert.AreEqual(new HexCubeCoordinates(-1, 0, 1), cube17);
            Assert.AreEqual(new HexCubeCoordinates(0, -1, 1), cube18);
            Assert.AreEqual(new HexCubeCoordinates(1, -2, 1), cube19);
            Assert.AreEqual(new HexCubeCoordinates(2, -3, 1), cube20);
            Assert.AreEqual(new HexCubeCoordinates(-3, 1, 2), cube21);
            Assert.AreEqual(new HexCubeCoordinates(-2, 0, 2), cube22);
            Assert.AreEqual(new HexCubeCoordinates(-1, -1, 2), cube23);
            Assert.AreEqual(new HexCubeCoordinates(0, -2, 2), cube24);
            Assert.AreEqual(new HexCubeCoordinates(1, -3, 2), cube25);
        }

        [Test]
        public void OffsetToCubeCoordinates_EvenR()
        {
            var hexLibrary = new HexLibrary(HexType.PointyTopped, OffsetCoordinatesType.Even, 64.0f);

            var cube1 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-2, -2));
            var cube2 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-1, -2));
            var cube3 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(0, -2));
            var cube4 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(1, -2));
            var cube5 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(2, -2));
            var cube6 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-2, -1));
            var cube7 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-1, -1));
            var cube8 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(0, -1));
            var cube9 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(1, -1));
            var cube10 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(2, -1));
            var cube11 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-2, 0));
            var cube12 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-1, 0));
            var cube13 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(0, 0));
            var cube14 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(1, 0));
            var cube15 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(2, 0));
            var cube16 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-2, 1));
            var cube17 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-1, 1));
            var cube18 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(0, 1));
            var cube19 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(1, 1));
            var cube20 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(2, 1));
            var cube21 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-2, 2));
            var cube22 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(-1, 2));
            var cube23 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(0, 2));
            var cube24 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(1, 2));
            var cube25 = hexLibrary.OffsetToCubeCoordinates(new HexOffsetCoordinates(2, 2));

            Assert.AreEqual(new HexCubeCoordinates(-1, 3, -2), cube1);
            Assert.AreEqual(new HexCubeCoordinates(0, 2, -2), cube2);
            Assert.AreEqual(new HexCubeCoordinates(1, 1, -2), cube3);
            Assert.AreEqual(new HexCubeCoordinates(2, 0, -2), cube4);
            Assert.AreEqual(new HexCubeCoordinates(3, -1, -2), cube5);
            Assert.AreEqual(new HexCubeCoordinates(-2, 3, -1), cube6);
            Assert.AreEqual(new HexCubeCoordinates(-1, 2, -1), cube7);
            Assert.AreEqual(new HexCubeCoordinates(0, 1, -1), cube8);
            Assert.AreEqual(new HexCubeCoordinates(1, 0, -1), cube9);
            Assert.AreEqual(new HexCubeCoordinates(2, -1, -1), cube10);
            Assert.AreEqual(new HexCubeCoordinates(-2, 2, 0), cube11);
            Assert.AreEqual(new HexCubeCoordinates(-1, 1, 0), cube12);
            Assert.AreEqual(new HexCubeCoordinates(0, 0, 0), cube13);
            Assert.AreEqual(new HexCubeCoordinates(1, -1, 0), cube14);
            Assert.AreEqual(new HexCubeCoordinates(2, -2, 0), cube15);
            Assert.AreEqual(new HexCubeCoordinates(-3, 2, 1), cube16);
            Assert.AreEqual(new HexCubeCoordinates(-2, 1, 1), cube17);
            Assert.AreEqual(new HexCubeCoordinates(-1, 0, 1), cube18);
            Assert.AreEqual(new HexCubeCoordinates(0, -1, 1), cube19);
            Assert.AreEqual(new HexCubeCoordinates(1, -2, 1), cube20);
            Assert.AreEqual(new HexCubeCoordinates(-3, 1, 2), cube21);
            Assert.AreEqual(new HexCubeCoordinates(-2, 0, 2), cube22);
            Assert.AreEqual(new HexCubeCoordinates(-1, -1, 2), cube23);
            Assert.AreEqual(new HexCubeCoordinates(0, -2, 2), cube24);
            Assert.AreEqual(new HexCubeCoordinates(1, -3, 2), cube25);
        }

        [Test]
        public void OffsetToAxialCoordinates_OddQ()
        {
            var hexLibrary = new HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Odd, 64.0f);

            var axial1 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-2, -2));
            var axial2 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-1, -2));
            var axial3 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(0, -2));
            var axial4 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(1, -2));
            var axial5 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(2, -2));
            var axial6 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-2, -1));
            var axial7 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-1, -1));
            var axial8 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(0, -1));
            var axial9 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(1, -1));
            var axial10 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(2, -1));
            var axial11 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-2, 0));
            var axial12 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-1, 0));
            var axial13 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(0, 0));
            var axial14 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(1, 0));
            var axial15 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(2, 0));
            var axial16 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-2, 1));
            var axial17 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-1, 1));
            var axial18 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(0, 1));
            var axial19 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(1, 1));
            var axial20 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(2, 1));
            var axial21 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-2, 2));
            var axial22 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-1, 2));
            var axial23 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(0, 2));
            var axial24 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(1, 2));
            var axial25 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(2, 2));

            Assert.AreEqual(new HexAxialCoordinates(-2, -1), axial1);
            Assert.AreEqual(new HexAxialCoordinates(-1, -1), axial2);
            Assert.AreEqual(new HexAxialCoordinates(0, -2), axial3);
            Assert.AreEqual(new HexAxialCoordinates(1, -2), axial4);
            Assert.AreEqual(new HexAxialCoordinates(2, -3), axial5);
            Assert.AreEqual(new HexAxialCoordinates(-2, 0), axial6);
            Assert.AreEqual(new HexAxialCoordinates(-1, 0), axial7);
            Assert.AreEqual(new HexAxialCoordinates(0, -1), axial8);
            Assert.AreEqual(new HexAxialCoordinates(1, -1), axial9);
            Assert.AreEqual(new HexAxialCoordinates(2, -2), axial10);
            Assert.AreEqual(new HexAxialCoordinates(-2, 1), axial11);
            Assert.AreEqual(new HexAxialCoordinates(-1, 1), axial12);
            Assert.AreEqual(new HexAxialCoordinates(0, 0), axial13);
            Assert.AreEqual(new HexAxialCoordinates(1, 0), axial14);
            Assert.AreEqual(new HexAxialCoordinates(2, -1), axial15);
            Assert.AreEqual(new HexAxialCoordinates(-2, 2), axial16);
            Assert.AreEqual(new HexAxialCoordinates(-1, 2), axial17);
            Assert.AreEqual(new HexAxialCoordinates(0, 1), axial18);
            Assert.AreEqual(new HexAxialCoordinates(1, 1), axial19);
            Assert.AreEqual(new HexAxialCoordinates(2, 0), axial20);
            Assert.AreEqual(new HexAxialCoordinates(-2, 3), axial21);
            Assert.AreEqual(new HexAxialCoordinates(-1, 3), axial22);
            Assert.AreEqual(new HexAxialCoordinates(0, 2), axial23);
            Assert.AreEqual(new HexAxialCoordinates(1, 2), axial24);
            Assert.AreEqual(new HexAxialCoordinates(2, 1), axial25);
        }

        [Test]
        public void OffsetToAxialCoordinates_EvenQ()
        {
            var hexLibrary = new HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Even, 64.0f);

            var axial1 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-2, -2));
            var axial2 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-1, -2));
            var axial3 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(0, -2));
            var axial4 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(1, -2));
            var axial5 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(2, -2));
            var axial6 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-2, -1));
            var axial7 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-1, -1));
            var axial8 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(0, -1));
            var axial9 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(1, -1));
            var axial10 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(2, -1));
            var axial11 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-2, 0));
            var axial12 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-1, 0));
            var axial13 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(0, 0));
            var axial14 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(1, 0));
            var axial15 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(2, 0));
            var axial16 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-2, 1));
            var axial17 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-1, 1));
            var axial18 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(0, 1));
            var axial19 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(1, 1));
            var axial20 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(2, 1));
            var axial21 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-2, 2));
            var axial22 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-1, 2));
            var axial23 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(0, 2));
            var axial24 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(1, 2));
            var axial25 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(2, 2));

            Assert.AreEqual(new HexAxialCoordinates(-2, -1), axial1);
            Assert.AreEqual(new HexAxialCoordinates(-1, -2), axial2);
            Assert.AreEqual(new HexAxialCoordinates(0, -2), axial3);
            Assert.AreEqual(new HexAxialCoordinates(1, -3), axial4);
            Assert.AreEqual(new HexAxialCoordinates(2, -3), axial5);
            Assert.AreEqual(new HexAxialCoordinates(-2, 0), axial6);
            Assert.AreEqual(new HexAxialCoordinates(-1, -1), axial7);
            Assert.AreEqual(new HexAxialCoordinates(0, -1), axial8);
            Assert.AreEqual(new HexAxialCoordinates(1, -2), axial9);
            Assert.AreEqual(new HexAxialCoordinates(2, -2), axial10);
            Assert.AreEqual(new HexAxialCoordinates(-2, 1), axial11);
            Assert.AreEqual(new HexAxialCoordinates(-1, 0), axial12);
            Assert.AreEqual(new HexAxialCoordinates(0, 0), axial13);
            Assert.AreEqual(new HexAxialCoordinates(1, -1), axial14);
            Assert.AreEqual(new HexAxialCoordinates(2, -1), axial15);
            Assert.AreEqual(new HexAxialCoordinates(-2, 2), axial16);
            Assert.AreEqual(new HexAxialCoordinates(-1, 1), axial17);
            Assert.AreEqual(new HexAxialCoordinates(0, 1), axial18);
            Assert.AreEqual(new HexAxialCoordinates(1, 0), axial19);
            Assert.AreEqual(new HexAxialCoordinates(2, 0), axial20);
            Assert.AreEqual(new HexAxialCoordinates(-2, 3), axial21);
            Assert.AreEqual(new HexAxialCoordinates(-1, 2), axial22);
            Assert.AreEqual(new HexAxialCoordinates(0, 2), axial23);
            Assert.AreEqual(new HexAxialCoordinates(1, 1), axial24);
            Assert.AreEqual(new HexAxialCoordinates(2, 1), axial25);
        }

        [Test]
        public void OffsetToAxialCoordinates_OddR()
        {
            var hexLibrary = new HexLibrary(HexType.PointyTopped, OffsetCoordinatesType.Odd, 64.0f);

            var axial1 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-2, -2));
            var axial2 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-1, -2));
            var axial3 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(0, -2));
            var axial4 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(1, -2));
            var axial5 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(2, -2));
            var axial6 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-2, -1));
            var axial7 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-1, -1));
            var axial8 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(0, -1));
            var axial9 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(1, -1));
            var axial10 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(2, -1));
            var axial11 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-2, 0));
            var axial12 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-1, 0));
            var axial13 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(0, 0));
            var axial14 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(1, 0));
            var axial15 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(2, 0));
            var axial16 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-2, 1));
            var axial17 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-1, 1));
            var axial18 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(0, 1));
            var axial19 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(1, 1));
            var axial20 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(2, 1));
            var axial21 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-2, 2));
            var axial22 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-1, 2));
            var axial23 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(0, 2));
            var axial24 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(1, 2));
            var axial25 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(2, 2));

            Assert.AreEqual(new HexAxialCoordinates(-1, -2), axial1);
            Assert.AreEqual(new HexAxialCoordinates(0, -2), axial2);
            Assert.AreEqual(new HexAxialCoordinates(1, -2), axial3);
            Assert.AreEqual(new HexAxialCoordinates(2, -2), axial4);
            Assert.AreEqual(new HexAxialCoordinates(3, -2), axial5);
            Assert.AreEqual(new HexAxialCoordinates(-1, -1), axial6);
            Assert.AreEqual(new HexAxialCoordinates(0, -1), axial7);
            Assert.AreEqual(new HexAxialCoordinates(1, -1), axial8);
            Assert.AreEqual(new HexAxialCoordinates(2, -1), axial9);
            Assert.AreEqual(new HexAxialCoordinates(3, -1), axial10);
            Assert.AreEqual(new HexAxialCoordinates(-2, 0), axial11);
            Assert.AreEqual(new HexAxialCoordinates(-1, 0), axial12);
            Assert.AreEqual(new HexAxialCoordinates(0, 0), axial13);
            Assert.AreEqual(new HexAxialCoordinates(1, 0), axial14);
            Assert.AreEqual(new HexAxialCoordinates(2, 0), axial15);
            Assert.AreEqual(new HexAxialCoordinates(-2, 1), axial16);
            Assert.AreEqual(new HexAxialCoordinates(-1, 1), axial17);
            Assert.AreEqual(new HexAxialCoordinates(0, 1), axial18);
            Assert.AreEqual(new HexAxialCoordinates(1, 1), axial19);
            Assert.AreEqual(new HexAxialCoordinates(2, 1), axial20);
            Assert.AreEqual(new HexAxialCoordinates(-3, 2), axial21);
            Assert.AreEqual(new HexAxialCoordinates(-2, 2), axial22);
            Assert.AreEqual(new HexAxialCoordinates(-1, 2), axial23);
            Assert.AreEqual(new HexAxialCoordinates(0, 2), axial24);
            Assert.AreEqual(new HexAxialCoordinates(1, 2), axial25);
        }

        [Test]
        public void OffsetToAxialCoordinates_EvenR()
        {
            var hexLibrary = new HexLibrary(HexType.PointyTopped, OffsetCoordinatesType.Even, 64.0f);

            var axial1 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-2, -2));
            var axial2 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-1, -2));
            var axial3 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(0, -2));
            var axial4 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(1, -2));
            var axial5 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(2, -2));
            var axial6 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-2, -1));
            var axial7 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-1, -1));
            var axial8 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(0, -1));
            var axial9 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(1, -1));
            var axial10 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(2, -1));
            var axial11 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-2, 0));
            var axial12 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-1, 0));
            var axial13 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(0, 0));
            var axial14 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(1, 0));
            var axial15 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(2, 0));
            var axial16 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-2, 1));
            var axial17 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-1, 1));
            var axial18 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(0, 1));
            var axial19 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(1, 1));
            var axial20 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(2, 1));
            var axial21 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-2, 2));
            var axial22 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(-1, 2));
            var axial23 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(0, 2));
            var axial24 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(1, 2));
            var axial25 = hexLibrary.OffsetToAxialCoordinates(new HexOffsetCoordinates(2, 2));

            Assert.AreEqual(new HexAxialCoordinates(-1, -2), axial1);
            Assert.AreEqual(new HexAxialCoordinates(0, -2), axial2);
            Assert.AreEqual(new HexAxialCoordinates(1, -2), axial3);
            Assert.AreEqual(new HexAxialCoordinates(2, -2), axial4);
            Assert.AreEqual(new HexAxialCoordinates(3, -2), axial5);
            Assert.AreEqual(new HexAxialCoordinates(-2, -1), axial6);
            Assert.AreEqual(new HexAxialCoordinates(-1, -1), axial7);
            Assert.AreEqual(new HexAxialCoordinates(0, -1), axial8);
            Assert.AreEqual(new HexAxialCoordinates(1, -1), axial9);
            Assert.AreEqual(new HexAxialCoordinates(2, -1), axial10);
            Assert.AreEqual(new HexAxialCoordinates(-2, 0), axial11);
            Assert.AreEqual(new HexAxialCoordinates(-1, 0), axial12);
            Assert.AreEqual(new HexAxialCoordinates(0, 0), axial13);
            Assert.AreEqual(new HexAxialCoordinates(1, 0), axial14);
            Assert.AreEqual(new HexAxialCoordinates(2, 0), axial15);
            Assert.AreEqual(new HexAxialCoordinates(-3, 1), axial16);
            Assert.AreEqual(new HexAxialCoordinates(-2, 1), axial17);
            Assert.AreEqual(new HexAxialCoordinates(-1, 1), axial18);
            Assert.AreEqual(new HexAxialCoordinates(0, 1), axial19);
            Assert.AreEqual(new HexAxialCoordinates(1, 1), axial20);
            Assert.AreEqual(new HexAxialCoordinates(-3, 2), axial21);
            Assert.AreEqual(new HexAxialCoordinates(-2, 2), axial22);
            Assert.AreEqual(new HexAxialCoordinates(-1, 2), axial23);
            Assert.AreEqual(new HexAxialCoordinates(0, 2), axial24);
            Assert.AreEqual(new HexAxialCoordinates(1, 2), axial25);
        }

        [Test]
        public void CubeToOffsetCoordinates_OddQ()
        {
            var hexLibrary = new HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Odd, 64.0f);

            var offset0 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(0, 0, 0));
            var offset1 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(0, 1, -1));
            var offset2 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(1, 0, -1));
            var offset3 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(1, -1, 0));
            var offset4 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(0, -1, 1));
            var offset5 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(-1, 0, 1));
            var offset6 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(-1, 1, 0));
            var offset7 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(-1, 2, -1));
            var offset8 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(0, 2, -2));
            var offset9 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(1, 1, -2));
            var offset10 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(2, 0, -2));
            var offset11 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(2, -1, -1));
            var offset12 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(2, -2, 0));
            var offset13 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(1, -2, 1));
            var offset14 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(0, -2, 2));
            var offset15 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(-1, -1, 2));
            var offset16 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(-2, 0, 2));
            var offset17 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(-2, 1, 1));
            var offset18 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(-2, 2, 0));

            Assert.AreEqual(new HexOffsetCoordinates(0, 0), offset0);
            Assert.AreEqual(new HexOffsetCoordinates(0, -1), offset1);
            Assert.AreEqual(new HexOffsetCoordinates(1, -1), offset2);
            Assert.AreEqual(new HexOffsetCoordinates(1, 0), offset3);
            Assert.AreEqual(new HexOffsetCoordinates(0, 1), offset4);
            Assert.AreEqual(new HexOffsetCoordinates(-1, 0), offset5);
            Assert.AreEqual(new HexOffsetCoordinates(-1, -1), offset6);
            Assert.AreEqual(new HexOffsetCoordinates(-1, -2), offset7);
            Assert.AreEqual(new HexOffsetCoordinates(0, -2), offset8);
            Assert.AreEqual(new HexOffsetCoordinates(1, -2), offset9);
            Assert.AreEqual(new HexOffsetCoordinates(2, -1), offset10);
            Assert.AreEqual(new HexOffsetCoordinates(2, 0), offset11);
            Assert.AreEqual(new HexOffsetCoordinates(2, 1), offset12);
            Assert.AreEqual(new HexOffsetCoordinates(1, 1), offset13);
            Assert.AreEqual(new HexOffsetCoordinates(0, 2), offset14);
            Assert.AreEqual(new HexOffsetCoordinates(-1, 1), offset15);
            Assert.AreEqual(new HexOffsetCoordinates(-2, 1), offset16);
            Assert.AreEqual(new HexOffsetCoordinates(-2, 0), offset17);
            Assert.AreEqual(new HexOffsetCoordinates(-2, -1), offset18);
        }

        [Test]
        public void CubeToOffsetCoordinates_EvenQ()
        {
            var hexLibrary = new HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Even, 64.0f);

            var offset0 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(0, 0, 0));
            var offset1 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(0, 1, -1));
            var offset2 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(1, 0, -1));
            var offset3 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(1, -1, 0));
            var offset4 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(0, -1, 1));
            var offset5 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(-1, 0, 1));
            var offset6 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(-1, 1, 0));
            var offset7 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(-1, 2, -1));
            var offset8 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(0, 2, -2));
            var offset9 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(1, 1, -2));
            var offset10 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(2, 0, -2));
            var offset11 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(2, -1, -1));
            var offset12 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(2, -2, 0));
            var offset13 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(1, -2, 1));
            var offset14 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(0, -2, 2));
            var offset15 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(-1, -1, 2));
            var offset16 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(-2, 0, 2));
            var offset17 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(-2, 1, 1));
            var offset18 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(-2, 2, 0));

            Assert.AreEqual(new HexOffsetCoordinates(0, 0), offset0);
            Assert.AreEqual(new HexOffsetCoordinates(0, -1), offset1);
            Assert.AreEqual(new HexOffsetCoordinates(1, 0), offset2);
            Assert.AreEqual(new HexOffsetCoordinates(1, 1), offset3);
            Assert.AreEqual(new HexOffsetCoordinates(0, 1), offset4);
            Assert.AreEqual(new HexOffsetCoordinates(-1, 1), offset5);
            Assert.AreEqual(new HexOffsetCoordinates(-1, 0), offset6);
            Assert.AreEqual(new HexOffsetCoordinates(-1, -1), offset7);
            Assert.AreEqual(new HexOffsetCoordinates(0, -2), offset8);
            Assert.AreEqual(new HexOffsetCoordinates(1, -1), offset9);
            Assert.AreEqual(new HexOffsetCoordinates(2, -1), offset10);
            Assert.AreEqual(new HexOffsetCoordinates(2, 0), offset11);
            Assert.AreEqual(new HexOffsetCoordinates(2, 1), offset12);
            Assert.AreEqual(new HexOffsetCoordinates(1, 2), offset13);
            Assert.AreEqual(new HexOffsetCoordinates(0, 2), offset14);
            Assert.AreEqual(new HexOffsetCoordinates(-1, 2), offset15);
            Assert.AreEqual(new HexOffsetCoordinates(-2, 1), offset16);
            Assert.AreEqual(new HexOffsetCoordinates(-2, 0), offset17);
            Assert.AreEqual(new HexOffsetCoordinates(-2, -1), offset18);
        }

        [Test]
        public void CubeToOffsetCoordinates_OddR()
        {
            var hexLibrary = new HexLibrary(HexType.PointyTopped, OffsetCoordinatesType.Odd, 64.0f);

            var offset0 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(0, 0, 0));
            var offset1 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(0, 1, -1));
            var offset2 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(1, 0, -1));
            var offset3 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(1, -1, 0));
            var offset4 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(0, -1, 1));
            var offset5 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(-1, 0, 1));
            var offset6 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(-1, 1, 0));
            var offset7 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(-1, 2, -1));
            var offset8 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(0, 2, -2));
            var offset9 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(1, 1, -2));
            var offset10 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(2, 0, -2));
            var offset11 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(2, -1, -1));
            var offset12 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(2, -2, 0));
            var offset13 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(1, -2, 1));
            var offset14 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(0, -2, 2));
            var offset15 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(-1, -1, 2));
            var offset16 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(-2, 0, 2));
            var offset17 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(-2, 1, 1));
            var offset18 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(-2, 2, 0));

            Assert.AreEqual(new HexOffsetCoordinates(0, 0), offset0);
            Assert.AreEqual(new HexOffsetCoordinates(-1, -1), offset1);
            Assert.AreEqual(new HexOffsetCoordinates(0, -1), offset2);
            Assert.AreEqual(new HexOffsetCoordinates(1, 0), offset3);
            Assert.AreEqual(new HexOffsetCoordinates(0, 1), offset4);
            Assert.AreEqual(new HexOffsetCoordinates(-1, 1), offset5);
            Assert.AreEqual(new HexOffsetCoordinates(-1, 0), offset6);
            Assert.AreEqual(new HexOffsetCoordinates(-2, -1), offset7);
            Assert.AreEqual(new HexOffsetCoordinates(-1, -2), offset8);
            Assert.AreEqual(new HexOffsetCoordinates(0, -2), offset9);
            Assert.AreEqual(new HexOffsetCoordinates(1, -2), offset10);
            Assert.AreEqual(new HexOffsetCoordinates(1, -1), offset11);
            Assert.AreEqual(new HexOffsetCoordinates(2, 0), offset12);
            Assert.AreEqual(new HexOffsetCoordinates(1, 1), offset13);
            Assert.AreEqual(new HexOffsetCoordinates(1, 2), offset14);
            Assert.AreEqual(new HexOffsetCoordinates(0, 2), offset15);
            Assert.AreEqual(new HexOffsetCoordinates(-1, 2), offset16);
            Assert.AreEqual(new HexOffsetCoordinates(-2, 1), offset17);
            Assert.AreEqual(new HexOffsetCoordinates(-2, 0), offset18);
        }

        [Test]
        public void CubeToOffsetCoordinates_EvenR()
        {
            var hexLibrary = new HexLibrary(HexType.PointyTopped, OffsetCoordinatesType.Even, 64.0f);

            var offset0 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(0, 0, 0));
            var offset1 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(0, 1, -1));
            var offset2 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(1, 0, -1));
            var offset3 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(1, -1, 0));
            var offset4 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(0, -1, 1));
            var offset5 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(-1, 0, 1));
            var offset6 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(-1, 1, 0));
            var offset7 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(-1, 2, -1));
            var offset8 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(0, 2, -2));
            var offset9 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(1, 1, -2));
            var offset10 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(2, 0, -2));
            var offset11 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(2, -1, -1));
            var offset12 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(2, -2, 0));
            var offset13 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(1, -2, 1));
            var offset14 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(0, -2, 2));
            var offset15 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(-1, -1, 2));
            var offset16 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(-2, 0, 2));
            var offset17 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(-2, 1, 1));
            var offset18 = hexLibrary.CubeToOffsetCoordinates(new HexCubeCoordinates(-2, 2, 0));

            Assert.AreEqual(new HexOffsetCoordinates(0, 0), offset0);
            Assert.AreEqual(new HexOffsetCoordinates(0, -1), offset1);
            Assert.AreEqual(new HexOffsetCoordinates(1, -1), offset2);
            Assert.AreEqual(new HexOffsetCoordinates(1, 0), offset3);
            Assert.AreEqual(new HexOffsetCoordinates(1, 1), offset4);
            Assert.AreEqual(new HexOffsetCoordinates(0, 1), offset5);
            Assert.AreEqual(new HexOffsetCoordinates(-1, 0), offset6);
            Assert.AreEqual(new HexOffsetCoordinates(-1, -1), offset7);
            Assert.AreEqual(new HexOffsetCoordinates(-1, -2), offset8);
            Assert.AreEqual(new HexOffsetCoordinates(0, -2), offset9);
            Assert.AreEqual(new HexOffsetCoordinates(1, -2), offset10);
            Assert.AreEqual(new HexOffsetCoordinates(2, -1), offset11);
            Assert.AreEqual(new HexOffsetCoordinates(2, 0), offset12);
            Assert.AreEqual(new HexOffsetCoordinates(2, 1), offset13);
            Assert.AreEqual(new HexOffsetCoordinates(1, 2), offset14);
            Assert.AreEqual(new HexOffsetCoordinates(0, 2), offset15);
            Assert.AreEqual(new HexOffsetCoordinates(-1, 2), offset16);
            Assert.AreEqual(new HexOffsetCoordinates(-1, 1), offset17);
            Assert.AreEqual(new HexOffsetCoordinates(-2, 0), offset18);
        }

        [Test]
        public void CubeToAxialCoordinates_Q()
        {
            var hexLibrary = new HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Odd, 64.0f);

            var axial0 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(0, 0, 0));
            var axial1 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(0, 1, -1));
            var axial2 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(1, 0, -1));
            var axial3 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(1, -1, 0));
            var axial4 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(0, -1, 1));
            var axial5 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(-1, 0, 1));
            var axial6 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(-1, 1, 0));
            var axial7 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(-1, 2, -1));
            var axial8 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(0, 2, -2));
            var axial9 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(1, 1, -2));
            var axial10 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(2, 0, -2));
            var axial11 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(2, -1, -1));
            var axial12 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(2, -2, 0));
            var axial13 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(1, -2, 1));
            var axial14 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(0, -2, 2));
            var axial15 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(-1, -1, 2));
            var axial16 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(-2, 0, 2));
            var axial17 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(-2, 1, 1));
            var axial18 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(-2, 2, 0));

            Assert.AreEqual(new HexAxialCoordinates(0, 0), axial0);
            Assert.AreEqual(new HexAxialCoordinates(0, -1), axial1);
            Assert.AreEqual(new HexAxialCoordinates(1, -1), axial2);
            Assert.AreEqual(new HexAxialCoordinates(1, 0), axial3);
            Assert.AreEqual(new HexAxialCoordinates(0, 1), axial4);
            Assert.AreEqual(new HexAxialCoordinates(-1, 1), axial5);
            Assert.AreEqual(new HexAxialCoordinates(-1, 0), axial6);
            Assert.AreEqual(new HexAxialCoordinates(-1, -1), axial7);
            Assert.AreEqual(new HexAxialCoordinates(0, -2), axial8);
            Assert.AreEqual(new HexAxialCoordinates(1, -2), axial9);
            Assert.AreEqual(new HexAxialCoordinates(2, -2), axial10);
            Assert.AreEqual(new HexAxialCoordinates(2, -1), axial11);
            Assert.AreEqual(new HexAxialCoordinates(2, 0), axial12);
            Assert.AreEqual(new HexAxialCoordinates(1, 1), axial13);
            Assert.AreEqual(new HexAxialCoordinates(0, 2), axial14);
            Assert.AreEqual(new HexAxialCoordinates(-1, 2), axial15);
            Assert.AreEqual(new HexAxialCoordinates(-2, 2), axial16);
            Assert.AreEqual(new HexAxialCoordinates(-2, 1), axial17);
            Assert.AreEqual(new HexAxialCoordinates(-2, 0), axial18);
        }

        [Test]
        public void CubeToAxialCoordinates_R()
        {
            var hexLibrary = new HexLibrary(HexType.PointyTopped, OffsetCoordinatesType.Odd, 64.0f);

            var axial0 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(0, 0, 0));
            var axial1 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(0, 1, -1));
            var axial2 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(1, 0, -1));
            var axial3 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(1, -1, 0));
            var axial4 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(0, -1, 1));
            var axial5 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(-1, 0, 1));
            var axial6 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(-1, 1, 0));
            var axial7 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(-1, 2, -1));
            var axial8 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(0, 2, -2));
            var axial9 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(1, 1, -2));
            var axial10 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(2, 0, -2));
            var axial11 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(2, -1, -1));
            var axial12 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(2, -2, 0));
            var axial13 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(1, -2, 1));
            var axial14 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(0, -2, 2));
            var axial15 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(-1, -1, 2));
            var axial16 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(-2, 0, 2));
            var axial17 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(-2, 1, 1));
            var axial18 = hexLibrary.CubeToAxialCoordinates(new HexCubeCoordinates(-2, 2, 0));

            Assert.AreEqual(new HexAxialCoordinates(0, 0), axial0);
            Assert.AreEqual(new HexAxialCoordinates(0, -1), axial1);
            Assert.AreEqual(new HexAxialCoordinates(1, -1), axial2);
            Assert.AreEqual(new HexAxialCoordinates(1, 0), axial3);
            Assert.AreEqual(new HexAxialCoordinates(0, 1), axial4);
            Assert.AreEqual(new HexAxialCoordinates(-1, 1), axial5);
            Assert.AreEqual(new HexAxialCoordinates(-1, 0), axial6);
            Assert.AreEqual(new HexAxialCoordinates(-1, -1), axial7);
            Assert.AreEqual(new HexAxialCoordinates(0, -2), axial8);
            Assert.AreEqual(new HexAxialCoordinates(1, -2), axial9);
            Assert.AreEqual(new HexAxialCoordinates(2, -2), axial10);
            Assert.AreEqual(new HexAxialCoordinates(2, -1), axial11);
            Assert.AreEqual(new HexAxialCoordinates(2, 0), axial12);
            Assert.AreEqual(new HexAxialCoordinates(1, 1), axial13);
            Assert.AreEqual(new HexAxialCoordinates(0, 2), axial14);
            Assert.AreEqual(new HexAxialCoordinates(-1, 2), axial15);
            Assert.AreEqual(new HexAxialCoordinates(-2, 2), axial16);
            Assert.AreEqual(new HexAxialCoordinates(-2, 1), axial17);
            Assert.AreEqual(new HexAxialCoordinates(-2, 0), axial18);
        }
    }
}