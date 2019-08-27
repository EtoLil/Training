using System;
using System.Collections.Generic;

namespace Training3.Task1
{
    class Task1
    {
        protected static List<Person> people = new List<Person>
        {
            new Person { Name = "Bill", Age = 15, PhoneNumbers = new List<string> { "380738983678", "380688983616", "380679983617" } },
            new Person { Name = "Bob", Age = 18, PhoneNumbers = new List<string> { "380961083618", "380731183619", "380671283620" } },
            new Person { Name = "Alice", Age = 24, PhoneNumbers = new List<string> { "380678138621", "380961513622", "380671583623" } },
            new Person { Name = "John", Age = 27, PhoneNumbers = new List<string> { "380501683624", "380931783625", "380671883626" } },
            new Person { Name = "Mark", Age = 11, PhoneNumbers = new List<string> { "380501983627", "380672083628", "380672183629" } },
            new Person { Name = "Edward", Age = 45, PhoneNumbers = new List<string> { "380932283630", "380672383631", "380672483632" } }
        };

        public static void MainTask1()
        {
            Console.WriteLine("Task1");
            GetInfo(people);
            Console.WriteLine();
        }

        private static void GetInfo(List<Person> people)
        {
            foreach (Person person in people)
            {
                Console.WriteLine("{0} - {1}", person.Name, person.Age);
            }
        }
    }
}
