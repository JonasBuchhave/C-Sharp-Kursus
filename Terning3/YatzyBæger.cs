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
            for (int i = 1; i < 7; i++)
            {
                if (Antal(i) == terninger.Length)
                    return true;
            }
            return false;
        }

        public bool FireEns()
        {
            for (int i = 1; i < 7; i++)
            {
                if (Antal(i) >= 4)
                    return true;
            }
            return false;
        }

        public bool TreEns()
        {
            for (int i = 1; i < 7; i++)
            {
                if (Antal(i) >= 3)
                    return true;
            }
            return false;
        }

        public int Antal(int værdi)
        {
            int tæller = 0;
            foreach (var item in terninger)
            {
                if (item.Værdi == værdi)
                    tæller++;
            }
            return tæller;
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
