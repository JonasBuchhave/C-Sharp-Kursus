using System;

namespace BrugAfEgetInterface
{
    class Ubåd : IDbFunktioner
    {
        public int Nummer { get; set; }
        public double Turbine { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer ubåd...");
        }
    }

}

