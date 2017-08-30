using System;

namespace Module03_ValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {


            //System.Int32 i;
            //System.Decimal komma;
            int i;
            decimal komma;
            DateTime dato = new DateTime(2017, 08, 29);
            dato = DateTime.Today;
            


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
