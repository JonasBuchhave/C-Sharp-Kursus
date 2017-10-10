using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrugAfUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uden using
            {
                StreamReader stream = File.OpenText(@"x:\dyrenavne.txt");
                while (stream.Peek() != -1)
                {
                    string navn = stream.ReadLine();
                    Console.WriteLine(navn);
                }
                stream.Close();
                stream = null;
            }

            //Mellemrum
            Console.WriteLine();

            //Det samme igen, blot med using
            {
                using (StreamReader stream = File.OpenText(@"x:\dyrenavne.txt"))
                {
                    while (stream.Peek() != -1)
                    {
                        string navn = stream.ReadLine();
                        Console.WriteLine(navn);
                    }
                }
            }


            //Vent...
            Console.ReadKey();
        }
    }
}
