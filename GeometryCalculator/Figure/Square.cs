using System;
using RedCunningFox.Planimetry.Exceptions;

namespace RedCunningFox.Planimetry
{
    public class Square : Figure
    {
        public double Side { 
            get { return _side; }
            set
            {
                if (value < 0)
                {
                    throw new NotValidArgumentException();
                }
                _side = value;
            }
        }
        public override double Area
        { 
            get 
            { 
                return Math.Pow(Side, 2);
            } 
        }
        public override double Perimeter
        {
            get
            {
                const double sideCount = 4;
                return Side * sideCount;
            }
        }

        #region Private

        private double _side;

        #endregion

        #region Constructors 
        public Square(double side)
        {
            Side = side;
        }
        #endregion
    }
}
