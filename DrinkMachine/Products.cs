using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DrinkMachine
{
    internal  class Products
    { 
        internal string Name { get; set; }
        internal float PriceS { get; set; }
        internal float PriceB { get; set; }

        //internal string SizeS { get; set; }
        //internal string SizeB { get; set; }


        public override string ToString()
        {
            return $"{Name} {PriceS} {PriceB}";
        }

        
    }
}
