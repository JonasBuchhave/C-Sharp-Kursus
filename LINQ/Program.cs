using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            var r = new PersonNuGetPackage.PersonRepositoryRandom();
            var people = r.GetPeople(10);
            foreach (var person in people)
                Console.WriteLine(person.Name);
            Console.WriteLine();

            //1
            Console.WriteLine("1a");
            var res1a = from person in people orderby person.Name select person;
            foreach (var person in res1a)
                Console.WriteLine(person.Name);
            Console.WriteLine();

            Console.WriteLine("1b");
            var res1b = people.OrderBy(person => person.Name);
            foreach (var person in res1b)
                Console.WriteLine(person.Name);
            Console.WriteLine();

            //2
            Console.WriteLine("2a");
            var res2a = from person in people orderby person.Gender, person.Name select person;
            foreach (var person in res2a)
                Console.WriteLine(person.Name + " - " + person.Gender);
            Console.WriteLine();

            Console.WriteLine("2b");
            var res2b = people.OrderBy(person => person.Gender).ThenBy(person => person.Name);
            foreach (var person in res2b)
                Console.WriteLine(person.Name + " - " + person.Gender);
            Console.WriteLine();

            //3
            Console.WriteLine("3a");
            var res3a = from person in people where person.Height > 170 select person;
            foreach (var person in res3a)
                Console.WriteLine(person.Name + " - " + person.Height);
            Console.WriteLine();

            Console.WriteLine("3b");
            var res3b = people.Where(person => person.Height > 170);
            foreach (var person in res3b)
                Console.WriteLine(person.Name + " - " + person.Height);
            Console.WriteLine();

            //4
            Console.WriteLine("4a");
            var res4a = from person in people where person.Height > 170 && person.IsHealthy select person;
            foreach (var person in res4a)
                Console.WriteLine(person.Name + " - " + person.Height + " - " + person.IsHealthy);
            Console.WriteLine();

            Console.WriteLine("4b");
            var res4b = people.Where(person => person.Height > 170 && person.IsHealthy);
            foreach (var person in res4b)
                Console.WriteLine(person.Name + " - " + person.Height + " - " + person.IsHealthy);
            Console.WriteLine();

            //5
            Console.WriteLine("5");
            var res5 = people.GroupBy(person => person.Gender);
            foreach (var group in res5)
            {
                foreach (var person in group)
                    Console.WriteLine(person.Name + " - " + person.Gender);
                Console.WriteLine();
            }

            //6
            Console.WriteLine("6");
            var res6 = people.OrderBy(person => person.Name).Select(person => new { Name = person.Name, Height = person.Height });
            foreach (var person in res6)
                Console.WriteLine(person.Name + " " + person.Height);
            Console.WriteLine();

            //7
            Console.WriteLine("7");
            int[] range = { 160, 170, 180, 190, 200, 210, 220 };
            var res7 = people.OrderBy(person => person.Height).GroupBy(person => range.FirstOrDefault(ra => ra > person.Height));
            foreach (var group in res7)
            {
                Console.WriteLine(group.Key);
                foreach (var person in group)
                    Console.WriteLine(person.Name + " - " + person.Height);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
