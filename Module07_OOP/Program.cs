namespace Module07_OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            TerningMedMetoder t = new TerningMedMetoder();
            t.SetVærdi(10);
            System.Console.WriteLine(t.GetVærdi());

            Terning t2 = new Terning();
            t2.Værdi = 5;
            System.Console.WriteLine(t2.Værdi);

            t2.Snyd = true;
            System.Console.WriteLine(t2.Snyd);

            Person p = new Person() { Navn="x", Alder=16, Land="DK" };



            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }

    internal class Person
    {
        public string Navn { get; set; }
        public int Alder { get; set; }
        public string Land { get; set; }

    }

}
