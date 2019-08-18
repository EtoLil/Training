using System;

namespace Training2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("1.Task1(abstract class Figure)\n2.Task2(readonly properties)\n3.Task3(virtual method Draw)\n4.Task4(interface IDrawable)");
                int menu;
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Task1:");
                        Task1.Figure[] figures1 = { new Task1.Square(), new Task1.Rectangle() };
                        figures1[0].Draw();
                        figures1[1].Draw();
                        Console.WriteLine("\n");
                        goto case 2;
                    case 2:
                        Console.WriteLine("Task2:");
                        Task2.Figure[] figures2 = { new Task2.Square(2, 3), new Task2.Rectangle(3, 6) };
                        figures2[0].GetInfo();
                        figures2[1].GetInfo();
                        Console.WriteLine("\n");
                        goto case 3;
                    case 3:
                        Console.WriteLine("Task3:");
                        Task3.Figure[] figures3 = { new Task3.Figure(2, 7), new Task3.Square(2, 3), new Task3.Rectangle(3, 6) };
                        figures3[0].GetInfo();
                        figures3[1].GetInfo();
                        figures3[2].GetInfo();
                        Console.WriteLine("\n");
                        goto case 4;
                    case 4:
                        Console.WriteLine("Task4:");
                        int num1, num2;
                        Console.WriteLine("Input number of classes!");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Task4.IDrawable[] figures4 = new Task4.IDrawable[num1];

                        for (int i = 0; i < num1; ++i)
                        {
                            Console.WriteLine("1.Figure\n2.Square\n3.Rectangle");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            switch (num2)
                            {
                                case 1:
                                    (double x1, double y1) = ReadInfo();
                                    Task4.Figure figure = new Task4.Figure(x1, y1);
                                    figures4[i] = figure;
                                    break;
                                case 2:
                                    (double x2, double y2) = ReadInfo();
                                    Task4.Square square = new Task4.Square(x2, y2);
                                    figures4[i] = square;
                                    break;
                                case 3:
                                    (double x3, double y3) = ReadInfo();
                                    Task4.Rectangle rectangle = new Task4.Rectangle(x3, y3);
                                    figures4[i] = rectangle;
                                    break;
                                default:
                                    Console.WriteLine("Incorrect number!");
                                    i--;
                                    break;
                            }
                        }

                        DrawAll(figures4);
                        break;
                    default:
                        Console.WriteLine("Incorrect number!");
                        break;
                }
            }
            catch (FormatException ex1)
            {
                Console.WriteLine($"Error: {ex1.Message}");
            }

            Console.ReadKey();
        }

        private static void DrawAll(params Task4.IDrawable[] array)
        {
            foreach (Task4.IDrawable obj in array)
            {
                obj.Draw();
            }
        }

        private static (double, double) ReadInfo()
        {
            double x, y;
            Console.WriteLine("Input X!");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input Y!");
            y = Convert.ToDouble(Console.ReadLine());

            return (x, y);
        }
    }
}
