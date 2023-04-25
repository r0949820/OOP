using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Email
    {
        public Persoon Verzender { get; set; }
        public Persoon Ontvanger { get; set; }
        public string Titel { get; set; }
        public string Bericht { get; set; }

        public Email(Persoon verzender, Persoon ontvanger, string titel, string bericht)
        {
            Verzender = verzender;
            Ontvanger = ontvanger;
            Titel = titel;
            Bericht = bericht;
        }

        public void Verstuur()
        {
            Console.WriteLine($"\nVolgende email wordt verstuurd:");
            Console.WriteLine($"Verzender: {Verzender} \nOntvanger: {Ontvanger}");
            Console.WriteLine($"Titel: {Titel}");
            Console.WriteLine($"Bericht: {Bericht}");
        }
    }
}
