namespace Training1
{
    internal class Circle
    {
        private const double Pi = 3.14;

        public double Square(double radius)
        {
            if (radius < 0)
            {
                throw new CircleException("Incorrect radius(radius must be greater than zero)!");
            }

            return Pi * radius * radius;
        }

        public double LengthOfCircle(double radius)
        {
            if (radius < 0)
            {
                throw new CircleException("Incorrect radius(radius must be greater than zero)!");
            }

            return 2 * Pi * radius;
        }
    }
}
