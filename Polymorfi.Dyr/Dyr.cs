using System;

namespace Polymorfi.Dyr
{
    abstract class Dyr
    {
        public string Navn { get; set; }
        private static Random rnd = new Random();

        //public virtual void SigNoget()
        //{
        //    Console.WriteLine($"Jeg er et dyr og hedder {this.Navn}");
        //}

        public abstract void SigNoget();

        public static Dyr TilfældigtDyr()
        {
            string sti = @"X:\dyrenavne.txt";
            string[] navne = System.IO.File.ReadAllLines(sti);

            string navn = navne[rnd.Next(0, navne.Length)];

            if (rnd.Next(1, 3) == 1)
                return new Hund() { Navn = navn };
            else
                return new Kat() { Navn = navn };
        }
    }

}
