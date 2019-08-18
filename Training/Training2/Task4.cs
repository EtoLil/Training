﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Figure:IDrawable
    {
        public virtual void Draw()
        {
            Console.WriteLine("class Figure");
        }
        public double X { get; }
        public double Y { get; }
        public Figure(double x, double y)
        {
            X = x;
            Y = y;
        }
        public virtual void GetInfo()
        {
            Draw();
            Console.WriteLine($"X = {X} Y = {Y}");
        }
    }

    class Square : Figure
    {
        public Square(double x, double y) : base(x, y)
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
        public override void Draw()
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