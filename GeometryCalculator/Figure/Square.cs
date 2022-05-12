using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator.Figure
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
