namespace lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MyName = "Максим";
            Console.WriteLine(MyName);

            Console.WriteLine("\t Hello World!");
            Console.WriteLine("\t Мне 35 лет");
            Console.WriteLine("\t My name is \n Max");

            Console.WriteLine('\u0040');
            Console.WriteLine('\x23');

            Console.WriteLine(0x0A);
            Console.WriteLine(0b11);
            Console.WriteLine(5.5);

            Console.WriteLine(true);
            Console.WriteLine(false);

            Console.WriteLine(5);

            Console.WriteLine("Пора спать!");

            Console.ReadKey();
        }
    }
}
