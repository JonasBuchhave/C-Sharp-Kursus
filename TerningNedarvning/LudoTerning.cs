namespace TerningNedarvning
{
    class LudoTerning : Terning
    {
        public LudoTerning() : base() { }

        public LudoTerning(int værdi) : base(værdi) { }

        public bool ErGlobus()
        {
            return this.Værdi == 3;
        }

        public bool ErStjerne()
        {
            return this.Værdi == 5;
        }
    }
}


