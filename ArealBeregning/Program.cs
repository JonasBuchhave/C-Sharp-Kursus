﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArealBeregning
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(ArealBeregninger.BeregnArealFirkant(10,10));
            Console.WriteLine(ArealBeregninger.BeregnArealCirkel(10));

            Console.ReadKey();
        }
    }
}
