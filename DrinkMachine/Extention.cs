using System;
using System.Collections.Generic;
using System.Text;

namespace DrinkMachine
{
    static class Extention
    {
        public static void HelloText(this string text)
        {
            Console.WriteLine("Witaj!");
            Console.WriteLine("Wybierz co chcesz kupic:");
            Console.WriteLine("S - Orange juice");
            Console.WriteLine("W - Water");
            Console.WriteLine("C- Cola");
        }
    }
}
