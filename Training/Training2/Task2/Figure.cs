 namespace Training2.Task2
{
    internal abstract class Figure
    {
        public Figure(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double X { get; }

        public double Y { get; }

        public abstract void Draw();

        public abstract void GetInfo();
    }
}
