using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GeometryCalculator
{
    public class Triangle : IFigure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle (double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double CalculateSquare()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public bool CheckRightTriangle()
        {
            if ((A* A + B* B == C* C) || (A* A + C* C == B* B) || (C* C + B* B == A* A))
            {
                return true;
            }
            return false;
        }
    }
}
