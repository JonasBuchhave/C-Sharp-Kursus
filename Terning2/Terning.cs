using System;

namespace Terning2
{
    class Terning
    {
        private int værdi;

        public int Værdi
        {
            get {
                Console.WriteLine($"Værdi læst: {værdi}");
                return værdi;
            }
            set
            {
                Console.Write($"Værdi skrevet: {value}");
                if (value < 1 || value > 6)
                {
                    value = 1;
                    Console.Write($"  =>  ugyldig værdi rettet til: {value}");
                }
                Console.WriteLine();
                værdi = value;
            }
        }

        private static Random rnd = new Random();

        public Terning()
        {

        }

        public Terning(int værdi)
        {
            this.Værdi = værdi;
        }


        //metoder
        public void Skriv()
        {
            Console.WriteLine("[" + this.værdi + "]");
        }

        public void Ryst()
        {
            this.værdi = rnd.Next(1, 7);
        }


    }

}
