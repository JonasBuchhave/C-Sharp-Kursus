namespace Module10_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            Tandbørste t = new Tandbørste();
            t.Stop();
            Turbine u = new Turbine();
            u.Stop();



            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }

    interface IMaskine
    {
        void Stop();
        int FejlKode();
        int StopMaskine(int statusKode);

    }

    class Tandbørste : IMaskine
    {
        public int FejlKode()
        {
            return 2;
        }

        public void Stop()
        {
            System.Console.WriteLine("Jeg stopper");
        }

        public int StopMaskine(int statusKode)
        {
            return statusKode + 1;
        }
    }

    class Turbine : IMaskine

    {
        public int FejlKode()
        {
            return 99;
        }

        public void Stop()
        {
            System.Console.WriteLine("Stort maskinstop");
        }

        public int StopMaskine(int statusKode)
        {
            return statusKode + 100;
        }
    }
}
