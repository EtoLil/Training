using System;
using System.Collections.Generic;
using System.Text;

namespace Training1
{
    class Circle
    {
        const double Pi = 3.14;

        public double Square(double radius)
        {
            if (radius < 0)
                throw new CircleException("Incorrect radius(radius must be greater than zero)!");
            return Pi * radius * radius;
        }
        public double LengthOfCircle(double radius)
        {
            if (radius < 0)
                throw new CircleException("Incorrect radius(radius must be greater than zero)!");
            return 2 * Pi * radius;
        }
    }
}
