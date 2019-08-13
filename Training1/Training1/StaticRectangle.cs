using System;
using System.Collections.Generic;
using System.Text;

namespace Training1
{
    static class StaticRectangle
    {
        public static double Square(Point p1, Point p2)
        {
            if (p1.x >= p2.x || p1.y <= p2.y)
                throw new RectangleException("Cannot construct rectangle!");
            var (Side1, Side2) = Side(p1, p2);
            return Side1 * Side2;
        }
        public static double Perimeter(Point p1, Point p2)
        {
            if (p1.x >= p2.x || p1.y <= p2.y)
                throw new RectangleException("Cannot construct rectangle!");
            var (Side1, Side2) = Side(p1, p2);
            return 2 * (Side1 + Side2);
        }
        public static (double Side1, double Side2) Side(Point p1, Point p2)
        {
            double Side1 = p1.y - p2.y;
            double Side2 = p2.x - p1.x;
            return (Side1, Side2);
        }

    }
}
