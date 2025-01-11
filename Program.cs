namespace lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Максим";
            byte MyAge = 27;
            bool HavePet = false;
            double Size = 42.5;

            Console.WriteLine("Hello World!");
            Console.WriteLine("Меня зовут " + MyName);
            Console.WriteLine("У тебя есть домашний питомец? " + HavePet);
            Console.WriteLine("Мой размер обуви " + Size);
            Console.ReadKey();
        }
    }
}
