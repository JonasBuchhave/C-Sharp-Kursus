using System;

namespace TerningNedarvning
{
    class Terning
    {
        private int værdi;

        public int Værdi
        {
            get {
                //log
                Console.WriteLine($"Værdien [{værdi}] læst!");
                //get
                return værdi;
            }
            set
            {
                //log
                Console.WriteLine($"Værdien [{værdi}] tildelt!");
                //set
                if (value < 1 || value > 6)
                    value = 1;
                værdi = value;
            }
        }

        private static System.Random rnd = new Random();

        public Terning()
        {
            this.Værdi = Ryst();
        }

        public Terning(int værdi)
        {
            this.Værdi = værdi;
        }

        public int Ryst()
        {
            return rnd.Next(1, 7);
        }

        public void Skriv()
        {
            Console.WriteLine($"[{this.Værdi}]");
        }

    }


}


