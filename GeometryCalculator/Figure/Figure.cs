using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator.Figure
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
