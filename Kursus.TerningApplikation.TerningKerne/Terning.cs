using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursus.TerningApplikation.TerningKerne
{
    public class Terning
    {
        private int værdi;

        public int Værdi
        {
            get { return værdi; }
            set { værdi = value; }
        }

        public Terning()
        {
            Ryst();
        }

        public Terning(int værdi)
        {
            this.Værdi = værdi;
        }

        public void Ryst()
        {
            Værdi = TerningFunktioner.TilfældigTal();
        }
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            return "[" + this.Værdi.ToString() + "]";
        }

    }
}
