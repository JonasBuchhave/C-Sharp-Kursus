using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag3_start
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = { 5,1,7,12,1,5 };
            ArrayResultat r = BeregnArray(v);
            Console.WriteLine(r.Sum);
            Console.WriteLine(r.Gennemsnit.ToString("N2"));
            Console.ReadKey();
        }

        static ArrayResultat BeregnArray(int[] værdier) {
            ArrayResultat resultat;
            resultat.Sum = 0;
            resultat.Gennemsnit = 0;

            for (int i = 0; i < værdier.Length; i++)
                resultat.Sum += værdier[i];
            resultat.Gennemsnit = resultat.Sum / værdier.Length;

            return resultat;
        }

    }

}
