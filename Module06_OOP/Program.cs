using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06_OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Person i = null;
            Console.WriteLine(i);

            i = new Person();
            Console.WriteLine(i);

            i.navn = "Jonas";
            i.alder = 39;
            i.erILive = true;


            Person u = new Person("Ditte", 35, true);

            Person w;

            u = null;
            u = i; //reference

            Console.WriteLine(i.navn);
            Console.WriteLine(u.navn);

            w = u;
            Console.WriteLine(w.navn);

            w = null;
            //Console.WriteLine(w.navn);  //nullpointer exception

            Console.WriteLine();
            Console.WriteLine();

            Terning t1 = new Terning();
            Terning t2 = new Terning(6);
            Terning t3 = new Terning(60);

            t1.Skriv();
            t2.Skriv();
            t3.Skriv();

            //t3.værdi = 100;
            t3.Skriv();
            Console.WriteLine("Værdien er: " + t3.HentVærdi());
            t3.GemVærdi(5);
            t3.Skriv();
            t3.GemVærdi(555);
            t3.Skriv();


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
