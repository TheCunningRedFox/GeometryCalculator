using System;

namespace RedCunningFox.Planimetry
{
    public class Triangle : Figure
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

        public override double GetSquare()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public override double GetPerimeter()
        {
            return A + B + C;
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
