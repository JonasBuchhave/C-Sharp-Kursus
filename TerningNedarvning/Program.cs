using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerningNedarvning
{
    class Program
    {
        static void Main(string[] args)
        {

            Terning t1 = new Terning();
            t1.Skriv();

            Console.WriteLine();

            LudoTerning t2 = new LudoTerning();
            t2.Skriv();
            Console.WriteLine(t2.ErGlobus());
            Console.WriteLine(t2.ErStjerne());
            
            Console.ReadKey();


        }
    }



}


