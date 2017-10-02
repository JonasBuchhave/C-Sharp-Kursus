using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursus.TerningApplikation.TerningKerne
{
    public class ForkertAntalTerningException : ApplicationException
    {
        public ForkertAntalTerningException(string txt) : base(txt)
        {}
    }
}
