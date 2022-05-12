using Xunit;
using GeometryCalculator;
using System;
using GeometryCalculator.Figure;
using static GeometryCalculator.GeometryCalculator;

namespace Tests
{
    public class CircleTest
    {
        [Fact]
        public void TestCircleCalculateSquare()
        {
            double r = 3;
            double expected = 28.27;
            var circle = new Сircle(r);
            double circleSquare = Math.Round(CalculateSquare(circle), 2);
            Assert.Equal(expected, circleSquare);
        }

        [Fact]
        public void TestCircleCalculatePerimeter()
        {
            double r = 10;
            double expected = 62.8;
            var circle = new Сircle(r);
            double circleSquare = Math.Round(CalculatePerimeter(circle), 1);
            Assert.Equal(expected, circleSquare);
        }
    }
}