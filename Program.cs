using System;
using System.Threading.Channels;

namespace lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как вас зовут?");
            var name = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Дата Вашего рождения? (в формате дд.мм.гггг)");
            var date = Console.ReadLine();
            Console.WriteLine("Ваше имя {0}, Вам {1} лет, дата Вашего рождения: {2}", name, age, date);
            Console.ReadKey();
        }
    }
}
