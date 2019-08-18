using System;

namespace Training2.Task3
{
    internal class Rectangle : Figure
    {
        public Rectangle(double x, double y)
            : base(x, y)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("class Rectangle");
        }

        public override void GetInfo()
        {
            this.Draw();
            Console.WriteLine($"X = {this.X} Y = {this.Y}");
        }
    }
}
