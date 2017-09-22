using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfi.Dyr
{
    class Program
    {
        static void Main(string[] args)
        {
            Dyr[] d = new Dyr[20];
            for (int i = 0; i < d.Length; i++)
                d[i] = Dyr.TilfældigtDyr();
    
            foreach (var item in d)
                item.SigNoget();
    
            Console.ReadKey();
        }
    }
}
