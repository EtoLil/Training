using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    abstract class Figure
    {
        public abstract void Draw();
        public abstract void GetInfo();
        public double X{ get;}
        public double Y { get; }
        public Figure(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    class Square : Figure
    {
        public Square(double x, double y):base(x,y)
        { }
        public override void Draw()
        {
            Console.WriteLine("class Square");
        }
        public override void GetInfo()
        {
            Draw();
            Console.WriteLine($"X = {X} Y = {Y}");
        }
    }
    class Rectangle : Figure
    {
        public Rectangle(double x, double y) : base(x, y)
        { }
        public override  void Draw()
        {
            Console.WriteLine("class Rectangle");
        }
        public override void GetInfo()
        {
            Draw();
            Console.WriteLine($"X = {X} Y = {Y}");
        }
    }
}
