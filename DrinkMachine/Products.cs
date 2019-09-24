using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DrinkMachine
{
    internal abstract class Products
    {
        internal Stack<Water> water { get; }
       
        internal string Name { get; set; }
        public override string ToString()
        {
            return $"{Name}";
        }
        internal Products()
        {
            water = new Stack<Water>();
            for (int i = 0; i < 3; i++)
            {
                water.Push(new Water());
            }
        }

        


        

    }
}
