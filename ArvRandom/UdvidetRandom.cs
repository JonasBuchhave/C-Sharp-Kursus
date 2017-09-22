using System;

namespace ArvRandom
{
    class UdvidetRandom : Random
    {
        public bool NextBool()
        {
            return this.Next(0, 1001) < 501;
        }
    }

}
