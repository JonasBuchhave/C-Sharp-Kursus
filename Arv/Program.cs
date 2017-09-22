using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person() { Fornavn = "Jonas", Efternavn = "Buchhave" };
            Console.WriteLine(p.FuldtNavn());

            Elev e = new Elev() { Fornavn = "Ditte", Efternavn = "Buchhave", Klasselokale = "På loftet" };
            Console.WriteLine(e.FuldtNavn());

            Instruktør i = new Instruktør() { Fornavn = "Liva", Efternavn = "Buchhave", NøgleId = 666 };
            Console.WriteLine(i.FuldtNavn());

            Console.ReadKey();
        }
    }

}
