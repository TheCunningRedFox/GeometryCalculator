using System;

namespace RedCunningFox.Planimetry
{
    public abstract class Figure : IFigure
    {
        public virtual double GetPerimeter()
        {
            throw new NotImplementedException();
        }

        public virtual double GetSquare()
        {
            throw new NotImplementedException();
        }
    }
}
