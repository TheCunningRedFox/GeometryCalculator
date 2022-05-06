using NUnit.Framework;
using GeometryCalculator;
using static GeometryCalculator.GeometryCalculator;

namespace TestGeometryCalculator
{
    public class Tests
    {
        [Fact]
        public void TestCircleCalculateSquare()
        {
            double r = 3;
            double expected = 28.26;
            var circle = new Ñircle(r);
            double circleSquare = CalculateSquare(circle);

            Assert.Equals(expected, circleSquare);
        }
    }
}