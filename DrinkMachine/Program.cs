using System;
using System.Collections.Generic;

namespace DrinkMachine
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = "Witaj";
            text.HelloText();
            bool startAgain = true;
            
            machine Machine = new machine();
            Console.WriteLine();
            int watt = Machine.water.Count;
            int coll = Machine.cola.Count;
            int jucc = Machine.juice.Count;


            do
            {

                
                var pr = Console.ReadKey();
                switch (pr.Key)
                {
                    case ConsoleKey.W:
                        if (Machine.water.Count > 0)
                        {
                            Console.WriteLine();
                            Machine.water.Pop();

                            string txt = watt - Machine.water.Count == 1 ? "wodę" : "wody";
                            Console.WriteLine($"Masz w koszyku {watt - Machine.water.Count} {txt} ");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Woda sie skonczyla");
                        }
                        break;
                    case ConsoleKey.C:
                        if (Machine.cola.Count > 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Kupiles cole");
                            Machine.cola.Pop();

                            string txt = coll - Machine.cola.Count <= 4 ? "colę" : "coli";
                            Console.WriteLine($"masz w koszyku {coll - Machine.cola.Count} {txt} ");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Cola sie skonczyła");
                        }
                        break;
                    case ConsoleKey.S:
                        if (Machine.juice.Count > 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Kupiles sok");
                            Machine.juice.Pop();

                            if (jucc - Machine.juice.Count == 1 )
                            {
                                Console.WriteLine($"Masz w koszyku {jucc - Machine.juice.Count} sok");
                            }
                            else if(jucc - Machine.juice.Count < 5 )
                                Console.WriteLine($"Masz w koszyku {jucc - Machine.juice.Count} soki");
                            else
                                Console.WriteLine($"Masz w koszyku {jucc - Machine.juice.Count} soków");

                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Sok sie skonczyl");
                        }
                        break;
                    default:
                        Console.WriteLine("nie mamy takiego produktu");
                        break;
                }
                Console.WriteLine("wcisnij enter, aby skonczyc zakupy");
                var next = Console.ReadKey();
            if(next.Key == ConsoleKey.Enter)
                {
                    startAgain = false;
                }
            else
                {
                    startAgain = true;
                    Console.WriteLine();
                }

            }
            while (startAgain);
            

        }
    }
}
