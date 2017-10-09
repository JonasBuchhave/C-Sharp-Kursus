using System;

namespace BrugAfEgetInterface
{
    class Hund : IDbFunktioner
    {
        public string Navn { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer hund...");
        }
    }

}

