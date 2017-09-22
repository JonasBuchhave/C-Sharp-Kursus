using System;

namespace Polymorfi.Dyr
{
    class Kat : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine($"Jeg er en kat og hedder {this.Navn}");
        }
    }

}
