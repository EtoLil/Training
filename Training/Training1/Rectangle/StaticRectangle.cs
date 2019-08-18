namespace Training1
{
    internal static class StaticRectangle
    {
        public static double Square(Point p1, Point p2)
        {
            if (p1.X >= p2.X || p1.Y <= p2.Y)
            {
                throw new RectangleException("Cannot construct rectangle!");
            }

            var (side1, side2) = Side(p1, p2);
            return side1 * side2;
        }

        public static double Perimeter(Point p1, Point p2)
        {
            if (p1.X >= p2.X || p1.Y <= p2.Y)
            {
                throw new RectangleException("Cannot construct rectangle!");
            }

            var (side1, side2) = Side(p1, p2);
            return 2 * (side1 + side2);
        }

        public static (double Side1, double Side2) Side(Point p1, Point p2)
        {
            double side1 = p1.Y - p2.Y;
            double side2 = p2.X - p1.X;
            return (side1, side2);
        }
    }
}
