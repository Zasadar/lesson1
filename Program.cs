using System;
using System.Threading.Channels;

namespace lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Максим";
            byte MyAge = 27;
            bool HavePet = false;
            double Size = 43.0;

            Console.WriteLine("Hello World!");
            Console.WriteLine("Меня зовут " + MyName);
            Console.WriteLine("У тебя есть домашний питомец? " + HavePet);
            Console.WriteLine("Мой размер обуви " + Size);
            
            Console.WriteLine("\nIntMin {0}", int.MinValue);
            Console.WriteLine("IntMax {0}", int.MaxValue);

            Console.WriteLine("Как вас зовут?");
            var name = Convert.ToString(Console.ReadLine());

            var age = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);

            Console.Write("What is your favorite day of week? ");

            var day = (DayOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine("Your favorite day is {0}", day);

            Console.ReadKey();
        }
        enum Semaphore
        {
            Read = 100, yellow = 200, green = 300
        }
    }
}
