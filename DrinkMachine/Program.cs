using System;
using System.Collections.Generic;

namespace DrinkMachine
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = "Hello";
            text.HelloText();
            Console.WriteLine("press e to finish shopping");
            bool startAgain = true;

            machine Machine = new machine();
            Console.WriteLine();
            int watt = Machine.water.Count;
            int coll = Machine.cola.Count;
            int jucc = Machine.juice.Count;

            while (startAgain)
            {
                var pr = Console.ReadKey();
                switch (pr.Key)
                {
                    case ConsoleKey.W:
                        if (Machine.water.Count > 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("you bought Water");
                            Machine.water.Pop();

                            string txt = watt - Machine.water.Count == 1 ? "water" : "waters";
                            Console.WriteLine($"You have in your basket {watt - Machine.water.Count} {txt} ");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("The water has run out");
                        }
                        break;
                    case ConsoleKey.C:
                        if (Machine.cola.Count > 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("You bought Cola");
                            Machine.cola.Pop();

                            string txt = "cola";
                            Console.WriteLine($"You have in your basket {coll - Machine.cola.Count} {txt} ");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("The Cola has run out");
                        }
                        break;
                    case ConsoleKey.S:
                        if (Machine.juice.Count > 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("You bought Juice");
                            Machine.juice.Pop();

                            if (jucc - Machine.juice.Count == 1)
                            {
                                Console.WriteLine($"Masz w koszyku {jucc - Machine.juice.Count} juice");
                            }
                                Console.WriteLine($"You have in your basket {jucc - Machine.juice.Count} juices");


                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Sok sie skonczyl");
                        }
                        break;
                    case ConsoleKey.E:
                        Console.WriteLine("Zapraszamy ponownie");
                        startAgain = false;
                        break;
                    default:
                        Console.WriteLine("nie mamy takiego produktu");
                        break;
                }                
            }
        }
    }
}