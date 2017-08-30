using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definér array
            int[] salary = { 10000, 20000, 15000, 20000, 30000, 15000 };

            //Udskriv
            for (int i = 0; i < salary.Length; i++) Console.WriteLine(salary[i]);
            Console.WriteLine("Gennemsnit " + salary.Average().ToString("n2"));

            //Blank linie
            Console.WriteLine();

            //Sortér array
            Array.Sort(salary);

            //Udskriv igen
            for (int i = 0; i < salary.Length; i++) Console.WriteLine(salary[i]);
            Console.WriteLine("Gennemsnit " + salary.Average().ToString("n2"));

            
            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
