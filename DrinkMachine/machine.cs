using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DrinkMachine
{
    internal class machine
    {
        internal Stack<Water> water { get; set; }
        internal Stack<Cola> cola { get; set; }
        internal Stack<OrangeJuice> juice { get; set; }
        internal machine()
        {

            water = new Stack<Water>();
            for (int i = 0; i < 10; i++)
            {
                water.Push(new Water());
            }
            cola = new Stack<Cola>();
            for (int i = 0; i < 13; i++)
            {
                cola.Push(new Cola());
            }
            juice = new Stack<OrangeJuice>();
            for (int i = 0; i < 7; i++)
            {
                juice.Push(new OrangeJuice());
            }
        }
        //internal List<Products> prod{ get; set; }

    }
}
