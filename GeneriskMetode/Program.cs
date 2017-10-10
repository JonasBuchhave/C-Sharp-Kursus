using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneriskMetode
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 16;
            int y = 32;
            Console.WriteLine(x + " " + y);
            Swap(ref x, ref y);
            Console.WriteLine(x + " " + y);

            Console.ReadKey();
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

    }
}
