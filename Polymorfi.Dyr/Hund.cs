using System;

namespace Polymorfi.Dyr
{
    class Hund : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine($"Jeg er en hund og hedder {this.Navn}");
        }
    }

}
