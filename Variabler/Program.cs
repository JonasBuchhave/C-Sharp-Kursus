using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabler
{
    class Program
    {
        static void Main(string[] args)
        {

            //Heltal
            int heltal = 10;
            heltal++;
            heltal--;
            heltal += 20;
            Console.WriteLine(heltal);
            Console.WriteLine("");

            //Kommatal
            double kommatal = 12.5;
            kommatal++;
            kommatal--;
            kommatal *= 2;
            Console.WriteLine(kommatal);
            Console.WriteLine("");

            //Enumeration
            Filtyper ft = Filtyper.csv;
            Console.WriteLine(Convert.ToInt32(ft));
            Console.WriteLine("");

            //Dato
            DateTime dato = DateTime.Now;
            Console.WriteLine(dato.ToString("ddMMyy"));
            Console.WriteLine(dato.ToString("dMy"));
            Console.WriteLine(dato.ToLongDateString());
            Console.WriteLine("");

            //Struktur
            Person p;
            p.Id = 1;
            p.Navn = "Mikkel";
            Console.WriteLine(p.Navn);
            Console.WriteLine("");


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
    public enum Filtyper
    {
        csv = 1,
        pdf = 2,
        txt = 3
    }

    public struct Person
    {
        public int Id;
        public string Navn;
    }
}
