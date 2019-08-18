namespace Training1
{
    internal class Rectangle
    {
        public Rectangle(Point p1, Point p2)
        {
            this.B = p1;
            this.D = p2;
        }

        public Point B { get; private set; }

        public Point D { get; private set; }

        public double Square
        {
            get { return this.SideAB * this.SideAD; }
        }

        public double Perimeter
        {
            get { return 2 * (this.SideAD + this.SideAB); }
        }

        private double SideAB
        {
            get { return this.B.Y - this.D.Y; }
        }

        private double SideAD
        {
            get { return this.D.X - this.B.X; }
        }

        public double S()
        {
            return this.SideAB * this.SideAD;
        }

        public double P()
        {
            return 2 * (this.SideAD + this.SideAB);
        }
    }
}
