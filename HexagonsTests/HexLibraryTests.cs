using NUnit.Framework;
using Zen.Hexagons;

namespace Zen.HexagonsTests
{
    public class HexLibraryTests
    {
        [Test]
        public void Test_FlatTopped()
        {
            IHex hexLibrary = new HexLibrary(HexType.FlatTopped, OffsetCoordinatesType.Odd, 64.0f);

            Assert.AreEqual(HexType.FlatTopped, hexLibrary.HexType);
            Assert.AreEqual(64.0f, hexLibrary.Size);
            Assert.AreEqual(128.0f, hexLibrary.Width);
            Assert.AreEqual(110.85125f, hexLibrary.Height);

            Assert.AreEqual(55.4256248f, hexLibrary.Apothem);
            Assert.AreEqual(110.85125f, hexLibrary.SideToSide);
            Assert.AreEqual(384.0f, hexLibrary.Perimeter);
            Assert.AreEqual(64.0f, hexLibrary.SideLength);
            Assert.AreEqual(64.0f, hexLibrary.CenterToVertex);
            Assert.AreEqual(128.0f, hexLibrary.VertexToVertex);
        }

        [Test]
        public void Test_PointyTopped()
        {
            IHex hexLibrary = new HexLibrary(HexType.PointyTopped, OffsetCoordinatesType.Odd, 64.0f);

            Assert.AreEqual(HexType.PointyTopped, hexLibrary.HexType);
            Assert.AreEqual(64.0f, hexLibrary.Size);
            Assert.AreEqual(110.85125f, hexLibrary.Width);
            Assert.AreEqual(128.0f, hexLibrary.Height);

            Assert.AreEqual(55.4256248f, hexLibrary.Apothem);
            Assert.AreEqual(110.85125f, hexLibrary.SideToSide);
            Assert.AreEqual(384.0f, hexLibrary.Perimeter);
            Assert.AreEqual(64.0f, hexLibrary.SideLength);
            Assert.AreEqual(64.0f, hexLibrary.CenterToVertex);
            Assert.AreEqual(128.0f, hexLibrary.VertexToVertex);
        }
    }
}