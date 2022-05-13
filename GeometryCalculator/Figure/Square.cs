using System;

namespace RedCunningFox.Planimetry
{
    public class Square : Figure
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }
        public override double GetSquare()
        {
            return Math.Pow(Side, 2);
        }

        public override double GetPerimeter()
        {
            const double sideCount = 4;
            return Side * sideCount;
        }
    }
}
