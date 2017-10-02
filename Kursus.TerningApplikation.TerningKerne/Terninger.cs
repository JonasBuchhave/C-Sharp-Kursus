using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursus.TerningApplikation.TerningKerne
{
    public class Terninger
    {
        private Terning[] terninger;

        public Terninger(int antal)
        {
            //// TODO: Smid fejl?
            //if (antal < 1 || antal > 6)
            //    antal = 1;
            if (antal < 1 || antal > 6)
                //throw new ApplicationException("Forkert antal terninger");
                throw new ForkertAntalTerningException("Forkert antal terninger");

            terninger = new Terning[antal];
            for (int i = 0; i < antal; i++)
                terninger[i] = new Terning();
        }

        public void Ryst()
        {
            for (int i = 0; i < terninger.Length; i++)
                terninger[i].Ryst();
        }

        public int Antal()
        {
            return this.terninger.Length;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < terninger.Length; i++)
                s.Append(terninger[i].ToString() + " ");
            return s.ToString().TrimEnd();
        }
    }
}
