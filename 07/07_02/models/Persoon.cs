using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Persoon
    {
        public string Voornaam { get; set; }
        public string Familienaam { get; set; }
        public string Emailadres { get; set; }

        public Persoon(string voornaam,string familienaam, string emailadres)
        {
            Voornaam = voornaam;
            Familienaam = familienaam;
            Emailadres = emailadres;
        }

        public override string ToString()
        {
            return $"{Voornaam} {Familienaam} ({Emailadres})";
        }
    }
}
