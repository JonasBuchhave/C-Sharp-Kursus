using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06_OOP
{
    public class Terning
    {
        private int værdi;

        public Terning() : this(1)
        {
            //this.værdi = 1;
        }

        public Terning(int startVærdi)
        {
            if (startVærdi < 1 || startVærdi > 6)
                this.værdi = 1;
            else
                this.værdi = startVærdi;

        }

        /// <summary>
        /// Skriver terningen ud til konsol
        /// </summary>
        public void Skriv()
        {
            Console.WriteLine("[" + this.værdi + "]");
        }

        public int HentVærdi()  //getter
        {
            return this.værdi;
        }

        public void GemVærdi(int værdi)  //setter
        {
            if (værdi < 1 || værdi > 6)
                this.værdi = 1;
            else
                this.værdi = værdi;

        }

    }
}
