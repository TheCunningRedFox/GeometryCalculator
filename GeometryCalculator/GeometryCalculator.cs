namespace GeometryCalculator
{
    public static class GeometryCalculator
    {
        public static double CalculateSquare(IFigure figure)
        {
            return figure.CalculateSquare();
        }

        public static bool IsRightTriangle (Triangle triangle) 
        {
            return triangle.CheckRightTriangle();
        }

    }
}