namespace RedCunningFox.Planimetry
{
    public static class GeometryCalculator
    {
        public static double CalculateSquare(IFigure figure)
        {
            return figure.GetSquare();
        }

        public static double CalculatePerimeter(IFigure figure)
        {
            return figure.GetPerimeter();
        }

        public static bool IsRightTriangle (Triangle triangle) 
        {
            return triangle.CheckRightTriangle();
        }

    }
}