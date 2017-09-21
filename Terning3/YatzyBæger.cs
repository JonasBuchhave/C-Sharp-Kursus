using System;

namespace Terning3
{
    class YatzyBæger
    {
        private Terning[] terninger = new Terning[5];

        public YatzyBæger()
        {
            for (int i = 0; i < terninger.Length; i++)
                terninger[i] = new Terning();
        }

        public void Ryst()
        {
            for (int i = 0; i < terninger.Length; i++)
                terninger[i].Ryst();
        }

        public bool Yatzy()
        {
            if (terninger[0].Værdi == terninger[1].Værdi &&
                terninger[1].Værdi == terninger[2].Værdi &&
                terninger[2].Værdi == terninger[3].Værdi &&
                terninger[3].Værdi == terninger[4].Værdi)
                return true;
            else
                return false;
        }

        public void Skriv()
        {
            for (int i = 0; i < terninger.Length; i++)
            {
                terninger[i].Skriv();
                if (i < terninger.Length - 1)
                    Console.Write(" ");
                else
                    Console.WriteLine();

            }
        }



    }



}
