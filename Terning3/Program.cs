using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terning3
{
    class Program
    {
        static void Main(string[] args)
        {
            YatzyBæger b = new YatzyBæger();
            b.Skriv();
            b.Ryst();
            b.Skriv();
            Console.WriteLine();

            int count = 0;
            while (b.Yatzy() == false)
            {
                b.Ryst();
                count++;
                Console.Write($"{count}: ");
                b.Skriv();
            }



            Console.ReadKey();
        }
    }



}
