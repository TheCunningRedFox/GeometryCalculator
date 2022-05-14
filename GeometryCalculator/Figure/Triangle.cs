using System;
using RedCunningFox.Planimetry.Exceptions;

namespace RedCunningFox.Planimetry
{
    public class Triangle : Figure
    {
        public double AB { 
            get { return _ab; }
            set
            {
                if ( value < 0)
                {
                    throw new NotValidArgumentException();
                }
                _ab = value;
            } 
        }
        public double BC { 
            get { return _bc; }
            set {
                if (value < 0)
                {
                    throw new NotValidArgumentException();
                }
                _bc = value; 
            } 
        }
        public double AC { 
            get { return _ac; }
            set
            {
                if (value < 0)
                {
                    throw new NotValidArgumentException();
                }
                _ac = value;
            }
        }
        public override double Area { 
            get
            {
                double p = (AB + BC + AC) / 2;
                return Math.Sqrt(p * (p - AB) * (p - BC) * (p - AC));
            }
        }
        public override double Perimeter
        {
            get { return AB + BC + AC; }
        }
        public bool IsRightTriangle
        {
            get
            {
                if ((AB * AB + BC * BC == AC * AC) || (AB * AB + AC * AC == BC * BC) || (AC * AC + BC * BC == AB * AB))
                {
                    return true;
                }
                return false;
            }
        }

        #region Private 

        private double _ab;
        private double _bc;
        private double _ac;

        #endregion

        #region Constructors 

        public Triangle (double a, double b, double c)
        {
            AB = a;
            BC = b;
            AC = c;
        }

        #endregion

    }
}
