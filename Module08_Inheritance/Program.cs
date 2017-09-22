namespace Module08_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            if (System.Diagnostics.Debugger.IsAttached)
            {

                Person o1 = new Person() { navn = "Jonas" };
                o1.print();

                Student o2 = new Student() { navn = "Ditte" };
                o2.print();


                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }

    class Person
    {
        public string navn { get; set; }
        public virtual void print()
        {
            System.Console.WriteLine("Jeg er en person, og hedder: " + this.navn);
        }
    }

    class Student : Person
    {
        public int StudentId { get; set; }
        public void BookEksamen() { }

        public override void print()
        {
            System.Console.WriteLine("Jeg er en person, og hedder: " + this.navn + " med ID: " + this.StudentId);
        }

    }

    class Instruktør : Person
    {
        public int Nøgle { get; set; }

    }

    class Hjælpeinstruktør : Instruktør { }


}
