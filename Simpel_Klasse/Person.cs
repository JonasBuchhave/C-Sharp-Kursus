using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpel_Klasse
{
    class Person
    {
        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;

        public Person()
        {
            this.Fornavn = "";
            this.Efternavn = "";
        }

        public Person(string fornavn, string efternavn, int fødselsår)
        {
            this.Fornavn = fornavn.ToUpper();
            this.Efternavn = efternavn.ToUpper();
            this.Fødselsår = fødselsår;
        }

        public string FuldtNavn()
        {
            return Fornavn + " " + Efternavn;
        }

        public int alder()
        {
            return DateTime.Today.Year - Fødselsår;
        }

    }
}
