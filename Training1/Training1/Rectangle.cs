using System;
using System.Collections.Generic;
using System.Text;

namespace Training1
{
    class Rectangle
    {
        public Point B { get; private set; }
        public Point D { get; private set; }
        public Rectangle(Point p1, Point p2)
        {
            B = p1;
            D = p2;
        }
        private double SideAB { get { return (B.y - D.y); } }
        private double SideAD { get { return (D.x - B.x); } }

        public double Square { get { return (SideAB * SideAD); } }
        public double Perimeter { get { return (2 * (SideAD + SideAB)); } }

        public double S()
        {
            return (SideAB * SideAD);
        }
        public double P()
        {
            return (2 * (SideAD + SideAB));
        }
    }
}
