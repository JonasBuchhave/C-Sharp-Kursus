using System;

namespace Terning3
{
    class Terning
    {
        private int værdi;

        public int Værdi
        {
            get
            {
                return værdi;
            }
            set
            {
                if (value < 1 || value > 6)
                    value = 1;
                værdi = value;
            }
        }

        private static Random rnd = new Random();

        public Terning()
        {
            this.Ryst();
        }

        public Terning(int værdi)
        {
            this.værdi = værdi;
        }
        
        //metoder
        public void Skriv()
        {
            Console.Write("[" + this.værdi + "]");
        }

        public void Ryst()
        {
            this.værdi = rnd.Next(1, 7);
        }

    }

}
