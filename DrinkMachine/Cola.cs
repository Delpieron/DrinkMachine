using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DrinkMachine 
{
    internal class Cola : Products
    {
        public Cola()
        {
            Name = "Cola";

            Stack cola = new Stack();
            cola.Push("Water");
            cola.Push("Water");
            cola.Push("Water");
        }

    }
}
