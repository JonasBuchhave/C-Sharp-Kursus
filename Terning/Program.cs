using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terning
{
    class Program
    {
        static void Main(string[] args)
        {

            Terning t1 = new Terning();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();

            Terning t2 = new Terning(true);
            t2.Skriv();
            t2.Ryst();
            t2.Skriv();


            Console.WriteLine();
            Terning t3 = new Terning();
            Terning t4 = new Terning();
            t3.Ryst();
            t4.Ryst();
            t3.Skriv();
            t4.Skriv();
            t3 = t4;
            t3.Skriv();
            t4.Skriv();
            t4.Ryst();
            t3.Skriv();
            t4.Skriv();



            Console.ReadKey();
        }
    }
}
