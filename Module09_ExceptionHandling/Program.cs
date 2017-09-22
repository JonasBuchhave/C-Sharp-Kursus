namespace Module09_ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            Dyr d = null;
            try
            {
                System.Console.WriteLine(d.ToString());
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }








            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }

    class Dyr { }

}
