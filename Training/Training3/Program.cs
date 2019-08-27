using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Training3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Input number of task!(1,2 or 3)");
                int number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        Task1.Task1.MainTask1();
                        goto case 2;
                    case 2:
                        Task2.Task2.MainTask2();
                        goto case 3;
                    case 3:
                        Task3.Task3.MainTask3();
                        break;
                    default:
                        Console.WriteLine("Incorrect number");
                        break;
                }
            }
            catch { }

            Console.ReadKey();
        }
    }
}
