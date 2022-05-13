using System;

namespace RedCunningFox.Planimetry
{
    public class Сircle : Figure
    {
        public double R { get; set; }
        public Сircle (double r)
        {
            R = r;
        }
        public override double GetSquare()
        {
            return Math.PI * Math.Pow(R, 2);
        }

        public override double GetPerimeter()
        {
            return 2 * R * Math.PI;
        }
    }
}
