using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://github.com/devcronberg/cs201708aa

namespace _10tabel
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 21; i++)
            {
                for (int j = 1; j < 21; j++)
                {
                    int tal = i * j;
                    if (tal >= 25) Console.ForegroundColor = ConsoleColor.DarkGreen;
                    if (tal >= 50) Console.ForegroundColor = ConsoleColor.Yellow;
                    if (tal >= 100) Console.ForegroundColor = ConsoleColor.Green;
                    if (tal >= 150) Console.ForegroundColor = ConsoleColor.Magenta;
                    if (tal >= 200) Console.ForegroundColor = ConsoleColor.Blue;
                    if (tal >= 250) Console.ForegroundColor = ConsoleColor.Cyan;
                    if (tal >= 300) Console.ForegroundColor = ConsoleColor.Red;
                    if (tal >= 350) Console.ForegroundColor = ConsoleColor.Gray;

                    Console.Write(tal.ToString().PadLeft(4));
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                Console.WriteLine();
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
