using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> p = new List<Person>();
            p.Add(new Person() { Id = 1, Navn = "Arne" });
            p.Add(new Person() { Id = 2, Navn = "Bent" });
            p.Add(new Person() { Id = 3, Navn = "Carl" });

            foreach (var item in p)
            {
                Console.WriteLine(item.Navn);
            }

            Dictionary<int, Person> dic = new Dictionary<int, Person>();
            dic.Add(1, new Person() { Id = 1, Navn = "Arne" });
            dic.Add(2, new Person() { Id = 2, Navn = "Bent" });
            dic.Add(3, new Person() { Id = 3, Navn = "Carl" });

            Console.WriteLine(dic[2].Navn);
            
            Console.ReadKey();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Navn { get; set; }
    }
}
