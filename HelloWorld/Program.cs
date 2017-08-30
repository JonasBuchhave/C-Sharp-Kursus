using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast navn");
            Console.WriteLine("Velkommen " + Console.ReadLine().ToUpper());
            Console.WriteLine("Tryk på en tast for at fortsætte");
            Console.ReadKey();
        }
    }
}
