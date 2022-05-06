using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    public class Сircle : IFigure
    {
        public double R { get; set; }
        public Сircle (double r)
        {
            R = r;
        }
        public double CalculateSquare()
        {
            return Math.PI * Math.Pow(R, 2);
        }
    }
}
