using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrugAfEgetInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbFunktioner[] idb = new IDbFunktioner[4];
            idb[0] = new Hund();
            idb[1] = new Ubåd();
            idb[2] = new Hund();
            idb[3] = new Ubåd();


            foreach (var item in idb)
            {
                item.Gem();
            }

            Console.ReadKey();
        }
    }
}

