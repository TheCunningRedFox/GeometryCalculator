using Xunit;
using RedCunningFox.Planimetry;
using static RedCunningFox.Planimetry.GeometryCalculator;

namespace Tests
{
    
    public class SquareTest
    {
        [Fact]
        public void TestSquareCalculateArea()
        {
            double side = 10;
            double expected = 100;
            var square = new Square(side);
            double squareSquare = CalculateArea(square);
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
