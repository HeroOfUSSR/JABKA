using System;

namespace JABKA
{

    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person();  // создание объекта класса Person

            // Получаем значение полей в переменные
            string personName = tom.name;
            int personAge = tom.age;
            Console.WriteLine($"Имя: {personName}  Возраст {personAge}");   // Имя: Undefined  Возраст: 0

            // устанавливаем новые значения полей
            tom.name = Console.ReadLine();
            var age = Console.ReadLine();
            bool result = int.TryParse(age, out var number);
            tom.age = number;

            new 
            // обращаемся к методу Print
            tom.Print();    // Имя: Tom  Возраст: 37
        }
    }
}
