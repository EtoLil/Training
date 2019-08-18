namespace Training1
{
    internal static class StaticCircle
    {
        private static readonly double Pi = 3.14;

        public static double Square(double radius)
        {
            if (radius < 0)
            {
                throw new CircleException("Incorrect radius(radius must be greater than zero)!");
            }

            return Pi * radius * radius;
        }

        public static double LengthOfCircle(double radius)
        {
            if (radius < 0)
            {
                throw new CircleException("Incorrect radius(radius must be greater than zero)!");
            }

            return 2 * Pi * radius;
        }
    }
}
