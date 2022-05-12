using Xunit;
using GeometryCalculator;
using System;
using GeometryCalculator.Figure;
using static GeometryCalculator.GeometryCalculator;

namespace Tests
{
    
    public class SquareTest
    {
        [Fact]
        public void TestSquareCalculateSquare()
        {
            double side = 10;
            double expected = 100;
            var square = new Square(side);
            double squareSquare = CalculateSquare(square);
            Assert.Equal(expected, squareSquare);
        }

        [Fact]
        public void TestSquareCalculatePerimeter()
        {
            double side = 10;
            double expected = 40;
            var square = new Square(side);
            double squareSquare = CalculatePerimeter(square);
            Assert.Equal(expected, squareSquare);
        }
    }
}
