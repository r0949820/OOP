using System;
using models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie
            string voornaam, achternaam;
            Werknemer werknemer;
            Klant klant;

            //Werknemer aanmaken
            voornaam = LeesStringNietLeeg("Beste werknemer, geef je voornaam: ");
            achternaam = LeesStringNietLeeg("Beste werknemer, geef je achternaam: ");

            werknemer = new Werknemer(voornaam, achternaam);

            Console.WriteLine(werknemer.ToonGegevens());

            //klant aanmaken
            voornaam = LeesStringNietLeeg("Beste klant, geef je voornaam: ");
            achternaam = LeesStringNietLeeg("Beste klant, geef je achternaam: ");

            klant = new Klant(voornaam, achternaam);

            Console.WriteLine(klant.ToonGegevens());


        }
        static string LeesStringNietLeeg(String vraag)
        {
            string invoer;

            do
            {
                Console.Write(vraag);
                invoer = Console.ReadLine();
            } while (string.IsNullOrEmpty(invoer));

            return invoer;
        }
    }
}
