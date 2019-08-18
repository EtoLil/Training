using System;

namespace Training1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("1.Rectangle\n2.Circle\n3.StaticRectangle\n4.StaticCircle\n5.ComplexNumber");
                int number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        Point p1 = ReadPoint();
                        Point p2 = ReadPoint();
                        if (p1.X >= p2.X || p1.Y <= p2.Y)
                        {
                            throw new RectangleException("Cannot construct rectangle!");
                        }

                        Rectangle rectangle = new Rectangle(p1, p2);
                        Console.WriteLine("1.Method\n2.Properties");
                        int menu = Convert.ToInt32(Console.ReadLine());
                        switch (menu)
                        {
                            case 1:
                                Console.WriteLine("Squre: " + rectangle.S());
                                Console.WriteLine("Perimeter: " + rectangle.P());
                                Console.WriteLine();
                                break;
                            case 2:
                                Console.WriteLine("Squre: " + rectangle.Square);
                                Console.WriteLine("Perimeter: " + rectangle.Perimeter);
                                break;
                            default:
                                Console.WriteLine("Incorrect number!");
                                break;
                        }

                        goto case 2;
                    case 2:
                        Console.WriteLine("Input radius!");
                        double radius1 = Convert.ToDouble(Console.ReadLine());
                        Circle circle = new Circle();
                        Console.WriteLine("LengthOfCircle: " + circle.LengthOfCircle(radius1));
                        Console.WriteLine("Square: " + circle.Square(radius1));
                        goto case 3;
                    case 3:
                        Point p3 = ReadPoint();
                        Point p4 = ReadPoint();
                        Console.WriteLine("Squre: " + StaticRectangle.Square(p3, p4));
                        Console.WriteLine("Perimeter: " + StaticRectangle.Perimeter(p3, p4));
                        goto case 4;
                    case 4:
                        Console.WriteLine("Input radius!");
                        double radius2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("LengthOfCircle: " + StaticCircle.LengthOfCircle(radius2));
                        Console.WriteLine("Square: " + StaticCircle.Square(radius2));
                        goto case 5;
                    case 5:
                        ComplexNumber c1 = new ComplexNumber();
                        ComplexNumber c2 = new ComplexNumber();
                        ComplexNumber c3 = new ComplexNumber();
                        c1.ReadComplex();
                        c2.ReadComplex();
                        c3 = c1 * c2;
                        ComplexNumber.Operation("*", c1, c2, c3);
                        c3 = c1 / c2;
                        ComplexNumber.Operation("/", c1, c2, c3);
                        break;
                    default:
                        Console.WriteLine("Incorrect number!");
                        break;
                }
            }
            catch (FormatException ex1)
            {
                Console.WriteLine("Error: " + ex1.Message);
            }
            catch (RectangleException ex2)
            {
                Console.WriteLine("Error: " + ex2.Message);
            }
            catch (CircleException ex3)
            {
                Console.WriteLine("Error: " + ex3.Message);
            }
            catch (ComplexNumberException ex4)
            {
                Console.WriteLine("Error: " + ex4.Message);
            }

            Console.ReadKey();
        }

        private static Point ReadPoint()
        {
            Console.WriteLine("Input x!");
            string input1 = Console.ReadLine();
            Console.WriteLine("Input y!");
            string input2 = Console.ReadLine();
            if ((!double.TryParse(input1, out double x)) || (!double.TryParse(input2, out double y)))
            {
                throw new RectangleException("Incorrect input(type-double)!");
            }

            return new Point(x, y);
        }
    }
}
