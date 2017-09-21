using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terning2
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t1 = new Terning();
            t1.Værdi = 8;

            Terning t2 = new Terning(3);

            Console.ReadKey();
        }
    }

}
