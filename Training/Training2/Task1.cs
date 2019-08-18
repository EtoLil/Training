using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    abstract class Figure
    {
        public abstract void Draw();
    }

    class Square:Figure
    {
        public override void Draw()
        {
            Console.WriteLine("class Square");
        }
    }
    class Rectangle : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("class Rectangle");
        }
    }
}
