namespace Arv
{
    class Person
    {
        public string Fornavn { get; set; }

        public string Efternavn { get; set; }

        public string FuldtNavn()
        {
            return $"{Fornavn} {Efternavn}";
        }
    }

}
