using System;

namespace Training2.Task3
{
    internal class Figure
    {
        public Figure(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double X { get; }

        public double Y { get; }

        public virtual void Draw()
        {
            Console.WriteLine("class Figure");
        }

        public virtual void GetInfo()
        {
            this.Draw();
            Console.WriteLine($"X = {this.X} Y = {this.Y}");
        }
    }
}
