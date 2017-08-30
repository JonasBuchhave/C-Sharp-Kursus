using System;

namespace Module04_ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                PersonStruct p1;
                p1.Id = 1;

                PersonStruct p2 = new PersonStruct();
                p2.Id = 2;

                p1 = p2;  //Kopierer værdier
                Console.WriteLine(p1.Id);
                Console.WriteLine(p2.Id);
                Console.WriteLine();

                PersonClass p3 = new PersonClass();
                p3.Id = 3;
                Console.WriteLine(p3.Id);
                Console.WriteLine();

                PersonClass p4 = new PersonClass();
                p4.Id = 4;

                p3 = p4;  //kopierer referencer
                Console.WriteLine(p3.Id);
                Console.WriteLine(p4.Id);
                Console.WriteLine();

                Console.WriteLine();




                int[] i;
                i = new int[5];

                int[] x = new int[5];

                x[0] = 2;
                x[1] = 5;
                x[3] = 76;
                //x[8] = 22;

                int[] xx = { 2, 5, 0, 76, 0 };

                Console.WriteLine(x[0]);
                Console.WriteLine(x);
                for (int r = 0; r < 5; r++)
                {
                    Console.WriteLine(x[r]);
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            {

                string u = null;
                //Console.WriteLine(u.ToString());

                u = "Mikkel";
                Console.WriteLine(u);
                Console.WriteLine(u.ToString());

                string w = u + " \t\t***\r\n " + u;
                Console.WriteLine(w);

                u = u.ToUpper();
                Console.WriteLine(u);


            }




            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    struct PersonStruct
    {
        public int Id;
    }

    class PersonClass
    {
        public int Id;
    }
}


