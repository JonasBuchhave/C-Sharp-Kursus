using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerningKerne
{
    internal static class TerningFunktioner
    {
        private static System.Random rnd = new Random();

        public static int TilfældigTal()
        {
            return rnd.Next(1, 7);
        }

    }
}
