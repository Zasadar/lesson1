using System;
using System.Drawing;
using System.Threading.Channels;

namespace lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите совй любимый цвет на английском с маленькой буквы");

            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Итерация {0}", i);
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ваш цвет красный!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ваш цвет зеленый!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Ваш цвет бирюзовый!");
                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ваш цвет желтый!");
                        break;
                }
            }


        }
    }
}
