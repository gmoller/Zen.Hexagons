using NUnit.Framework;
using Zen.Hexagons;

namespace Zen.HexagonsTests
{
    [TestFixture]
    public class PerformanceTests
    {
        [Test]
        public void Test_performance_of_get_corners()
        {
            const int iterations = 10000000;

            var hex = new HexFlatTopped(OffsetCoordinatesType.Even, 100, true);
            for (var i = 0; i < iterations; i++)
            {
                var corners = hex.GetCorners();
            }
        }
    }
}