using Xunit;
using GeometryCalculator;
using System;
using static GeometryCalculator.GeometryCalculator;

namespace TestProject1
{
    public class TestGeometryCalculator
    {
        [Fact]
        public void TestCircleCalculateSquare()
        {
            double r = 3;
            double expected = 28.27;
            var circle = new Ñircle(r);
            double circleSquare = CalculateSquare(circle);
            Assert.Equal(expected, Math.Round(circleSquare, 2));
        }

        [Fact]
        public void TestTriangleCalculateSquare()
        {
            double a = 14;
            double b = 13;
            double c = 15;
            double expected = 84;
            var triangle = new Triangle(a, b, c);
            double triangleSquare = CalculateSquare(triangle);
            Assert.Equal(expected, Math.Round(triangleSquare, 2));
        }

        [Fact]
        public void TestTriangleIsRight()
        {
            double a = 5;
            double b = 13;
            double c = 12;
            bool expected = true;
            var triangle = new Triangle(a, b, c);
            bool isRightTriangle = IsRightTriangle(triangle);
            Assert.Equal(expected, isRightTriangle);
        }
    }
}