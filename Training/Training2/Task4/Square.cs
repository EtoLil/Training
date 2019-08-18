using System;

namespace Training2.Task4
{
    internal class Square : Figure
    {
        public Square(double x, double y)
            : base(x, y)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("class Square");
        }

        public override void GetInfo()
        {
            this.Draw();
            Console.WriteLine($"X = {this.X} Y = {this.Y}");
        }
    }
}
