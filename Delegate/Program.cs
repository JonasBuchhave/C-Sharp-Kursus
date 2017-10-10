using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = Beregn(6, 2, Plus);
            Console.WriteLine(res);
            res = Beregn(6, 2, Minus);
            Console.WriteLine(res);
            res = Beregn(6, 2, Gange);
            Console.WriteLine(res);
            res = Beregn(6, 2, Divider);
            Console.WriteLine(res);

            Console.ReadKey();
        }

        public delegate int BeregnDelegate(int a, int b);

        public static int Beregn(int a,int b, BeregnDelegate f) { return f(a, b); }

        public static int Plus(int a, int b) { return a + b; }

        public static int Minus(int a, int b) { return a - b; }

        public static int Gange(int a, int b) { return a * b; }

        public static int Divider(int a, int b) { return a / b; }


    }
}
