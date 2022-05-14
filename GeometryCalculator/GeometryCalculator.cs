namespace RedCunningFox.Planimetry
{
    public static class GeometryCalculator
    {
        public static double CalculateArea(IFigure figure)
        {
            return figure.Area;
        }

        public static double CalculatePerimeter(IFigure figure)
        {
            return figure.Perimeter;
        }

        public static bool IsRightTriangle (Triangle triangle) 
        {
            return triangle.CheckRightTriangle();
        }

    }
}