using System;
using RedCunningFox.Planimetry.Exceptions;

namespace RedCunningFox.Planimetry
{
    public class Circle : Figure
    {
        public double Radius { 
            get { return _radius; }
            set 
            {
                if (value < 0)
                {
                    throw new NotValidArgumentException();
                }
                _radius = value;
            }
        }
        public override double Area
        { 
            get 
            {
                return Math.PI* Math.Pow(Radius, 2);
            } 
        }
        public override double Perimeter { 
            get
            {
                return 2 * Radius * Math.PI;
            } 
        }

        #region Private

        private double _radius;

        #endregion

        #region Constructors

        public Circle (double radius)
        {
            Radius = radius;
        }
        public Circle() { }

        #endregion 
    }
}
