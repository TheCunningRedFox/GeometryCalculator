using Xunit;
using RedCunningFox.Planimetry;
using System;
using static RedCunningFox.Planimetry.GeometryCalculator;

namespace Tests
{
    public class CircleTest
    {
        [Fact]
        public void TestCircleCalculateArea()
        {
            double r = 3;
            double expected = 28.27;
            var circle = new Circle(r);
            double circleSquare = Math.Round(CalculateArea(circle), 2);
            Assert.Equal(expected, circleSquare);
        }

        [Fact]
        public void TestCircleCalculatePerimeter()
        {
            double r = 10;
            double expected = 62.8;
            var circle = new Circle(r);
            double circleSquare = Math.Round(CalculatePerimeter(circle), 1);
            Assert.Equal(expected, circleSquare);
        }
    }
}