using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpel_Klasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Jonas","Buchhave",1978);
            Person p2 = new Person("Ditte","Buchhave",1982);

            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p1.alder());
            Console.WriteLine(p2.FuldtNavn());
            Console.WriteLine(p2.alder());

            Console.ReadKey();
        }
    }
}
