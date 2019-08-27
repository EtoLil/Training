using System;
using System.Collections.Generic;

namespace Training3.Task3
{
    class Task3
    {
        private const int COUNT_OF_ELEMENTS_IN_PAGE = 5;
        private const int COUNT_OF_ELEMENTS_IN_LIST = 101;
        private const int LENGTH_OF_STR = 4;

        private static List<string> str;

        private static readonly char[] ABC =
        {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K',
            'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U',
            'V', 'W', 'X', 'Y', 'Z'
        };

        public static void MainTask3()
        {
            try
            {
                Console.WriteLine("Task3");
                str = GenerationLines();
                Console.WriteLine("Old lenght : {0}", str.Count);
                Transformation();
                Console.WriteLine("Current length: {0},", str.Count);

                int number;
                Console.WriteLine("Input number of page!");

                number = Convert.ToInt32(Console.ReadLine());
                if (IsPageValid(number, str.Count))
                {
                    DisplayPage(number);
                }

                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static List<string> GenerationLines()
        {
            string[] masStr = new string[COUNT_OF_ELEMENTS_IN_LIST];
            string str = "";
            Random rand = new Random();
            int numberOfLetter;
            for (int i = 0; i < COUNT_OF_ELEMENTS_IN_LIST; ++i)
            {
                for (int j = 0; j < LENGTH_OF_STR; ++j)
                {
                    numberOfLetter = rand.Next(26);
                    str += ABC[numberOfLetter];
                }

                masStr[i] = str;
                str = "";
            }

            return new List<string>(masStr);
        }

        private static void Transformation()
        {
            HashSet<string> temp = new HashSet<string>(str);
            str = new List<string>();
            str.AddRange(temp);
            for (int i = 0; i < str.Count; ++i)
            {
                if (str[i][0] == 'Z')
                {
                    str.RemoveAt(i);
                    i--;
                }
            }

            str.Sort();
            str.Reverse();
        }

        private static bool IsPageValid(int page, int listLength)
        {
            if (page <= 0 || ((page - 1) * COUNT_OF_ELEMENTS_IN_PAGE) > listLength)
            {
                return false;
            }

            return true;
        }

        private static void DisplayPage(int pageNumber)
        {
            int startElement = (pageNumber - 1) * COUNT_OF_ELEMENTS_IN_PAGE;
            for (int i = startElement; i < COUNT_OF_ELEMENTS_IN_PAGE; ++i)
            {
                Console.Write($" {str[i]}   ");
            }

            Console.WriteLine();
        }
    }
}
