using System;
using System.Collections.Generic;
using System.Linq;
using models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Maak een nieuwe lijst van TvKanaal objecten
            List<TvKanaal> tvKanalen = new List<TvKanaal>();

            // Voeg 5 nieuwe objecten toe aan de lijst
            tvKanalen.Add(new TvKanaal(1, "Een"));
            tvKanalen.Add(new TvKanaal(2, "Canvas"));
            tvKanalen.Add(new TvKanaal(3, "VTM"));
            tvKanalen.Add(new TvKanaal(4, "2BE"));
            tvKanalen.Add(new TvKanaal(5, "Vier"));

            // Toon alle kanalen
            foreach (TvKanaal kanaal in tvKanalen)
            {
                Console.WriteLine(kanaal.Omschrijving);
            }

            // Vraag de gebruiker om een kanaalnummer in te voeren
            Console.WriteLine("Van welk kanaal wil je het nummer tonen?");
            string ingevoerdeOmschrijving = Console.ReadLine();

            // Zoek het kanaalnummer op basis van de ingevoerde omschrijving
            TvKanaal gevondenKanaal = tvKanalen.FirstOrDefault(k => k.Omschrijving.Equals(ingevoerdeOmschrijving, StringComparison.OrdinalIgnoreCase));

            // Toon het kanaalnummer als het gevonden is
            if (gevondenKanaal != null)
            {
                Console.WriteLine(gevondenKanaal.ToString());
            }
            else
            {
                Console.WriteLine("Kanaal niet gevonden");
            }


        }
    }
}
