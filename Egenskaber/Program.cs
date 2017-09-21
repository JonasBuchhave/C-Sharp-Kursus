using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egenskaber
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare v = new Vare();
            v.Navn = "Ost";
            v.Pris = 123.45;
            Console.WriteLine(v.PrisMedMoms());

            Vare v2 = new Vare("Hest",1000);
            Console.WriteLine(v2.PrisMedMoms());

            Console.ReadKey();
        }
    }

    class Vare
    {
        private string navn;

        public string Navn
        {
            get {
                Console.WriteLine($"Navn læst: {navn}");
                return navn;
            }
            set {
                Console.WriteLine($"Navn skrevet: {value}");
                navn = value;
            }
        }

        private double pris;

        public double Pris
        {
            get {
                Console.WriteLine($"Pris læst: {pris}");
                return pris;
            }
            set {
                Console.WriteLine($"Pris skrevet: {value}");
                pris = value;
            }
        }


        public Vare()
        {
            Navn = "";
            Pris = 0;
        }

        public Vare(string navn, double pris)
        {
            this.Navn = navn;
            this.Pris = pris;
        }
        
        public double PrisMedMoms()
        {
            return Pris*1.25;
        }



    }

}
