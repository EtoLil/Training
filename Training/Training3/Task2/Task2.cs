using System;
using System.Collections.Generic;
using Training3.Task1;

namespace Training3.Task2
{
    class Task2 : Task1.Task1
    {
        public static void MainTask2()
        {
            Console.WriteLine("Task2");
            List<Person> people2 = new List<Person>
            {
                new Person { Name = "Allison", Age = 30, PhoneNumbers = new List<string> { "380507683630", "380677783631", "380677883632" } },
                new Person { Name = "Steve", Age = 34, PhoneNumbers = new List<string> { "380677983630", "380678083631", "380678183632" } }
            };

            people.AddRange(people2);
            GetNumbers(people);
            Console.WriteLine();
        }

        private static void GetNumbers(List<Person> people)
        {
            foreach (Person person in people)
            {
                foreach (string phoneNumber in person.PhoneNumbers)
                {
                    Console.Write($"  {phoneNumber}    ");
                }

                Console.WriteLine();
            }
        }
    }
}
