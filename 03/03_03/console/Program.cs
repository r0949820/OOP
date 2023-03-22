using System;
using models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            // declareren van variabelen
            string output = $"Persoonsgegevens\n" +
                $"{new string('-', "persoonsgegevens".Length)}\n";
            string voornaam = VraagGegevens("Geef een voornaam: ");
            string familienaam = VraagGegevens("Geef een familienaam: ");
            string rijksregisternummer = VraagGegevens("Geef een rijksregisternummer: ");
            string iban = VraagGegevens("Geef een Iban: ");

            // output aanpassen en weergeven
            Console.Clear();
            output += $"\nVolledige naam: {voornaam} {familienaam}";
            output += $"\nRijksregisternummer: {GeldigheidPersoongegevens.ControleRijksregisternummer(rijksregisternummer)}";
            output += $"\nIBAN: {GeldigheidPersoongegevens.ControleIban(iban)}";
            Console.WriteLine(output);

        }
        private static string VraagGegevens(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
    }
}
