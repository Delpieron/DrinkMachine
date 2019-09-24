using System;

namespace DrinkMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz co chcesz kupic");
            Console.WriteLine("s - Orange juice");
            Console.WriteLine("W - Water");
            Console.WriteLine("c- Cola");
            Water water = new Water();

            var pr = Console.ReadKey();
            switch (pr.Key)
            {
                case ConsoleKey.S:
                    Console.WriteLine();
                    Console.WriteLine("twoja stara");
                    break;
                case ConsoleKey.W:
                    Console.WriteLine();
                    Console.WriteLine("kupiles wode");
                    Console.WriteLine(water.water.Count);
                    water.water.Pop();
                    Console.WriteLine(water.water.Count);

                    break;
                case ConsoleKey.C:
                    Console.WriteLine();
                    Console.WriteLine("C");
                    break;
                default:
                    Console.WriteLine("podales zla litere baranie");
                    break;
            }

            Console.Read();

        }
    }
}
