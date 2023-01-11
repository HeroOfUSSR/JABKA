using System;

namespace JABKA
{

    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person();  // создание объекта класса Person

            int count = GetNumber("Print count");

            var People = new Person[count];

            for (int i = 0; i < count; i++)
            {
                var person = new Person();
                People[i] = person;
                Console.WriteLine("Print name");
                person.name = Console.ReadLine();
                person.age = GetNumber("Print age");

            }

            Sort(People);

            foreach (var person in People)
            {
                person.Print();
            }

            Console.ReadKey();

        }

        private static void Sort(Person[] cycle )
        {
            for (int i = 0; i < cycle.Length - 1; i++)
            {
                for (int j = i + 1; j < cycle.Length; j++)
                {
                    if (cycle[i].age > cycle[j].age)
                    {
                        var temp = cycle[i];
                        cycle[i] = cycle[j];
                        cycle[j] = temp;
                    }
                }
            }
        }


        private static int GetNumber(string printMessage)
        {
            int number;
            while (true)
            {
                Console.WriteLine(printMessage);
                var countStr = Console.ReadLine();

                if (int.TryParse(countStr, out number))
                {
                    break;
                }

                Console.WriteLine($"{countStr} is not a number");
            }
            return number;
        }
    }
}
