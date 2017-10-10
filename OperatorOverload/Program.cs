using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund h1 = new Hund() { Navn = "A", LydNiveau = 30 };
            Hund h2 = new Hund() { Navn = "B", LydNiveau = 20 };
            Console.WriteLine(h1 > h2);
            Console.WriteLine(h1 < h2);

            Console.ReadKey();
        }
    }

    class Hund
    {
        public string Navn { get; set; }
        public int LydNiveau { get; set; }

        //Operator overload
        public static bool operator >(Hund o1, Hund o2) { return o1.LydNiveau > o2.LydNiveau; }
        public static bool operator <(Hund o1, Hund o2) { return o1.LydNiveau < o2.LydNiveau; }

    }

}
