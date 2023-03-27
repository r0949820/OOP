using models;
using System;
using System.Collections.Generic;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            // vraag de gebruiker om een spel te kiezen
            Console.Write("Kies een spel (1, 2, of 3): ");
            string spelBestand = Console.ReadLine();

            // lees de kaarten in uit het bestand
            List<Kaart> kaarten = FileOperations.LeesFile(spelBestand);

            // start het spel
            Console.WriteLine("Het spel begint.");
            Console.WriteLine();

            int scoreComputer = 0;
            int scoreSpeler = 0;

            foreach (Kaart kaart in kaarten)
            {
                // vraag de speler om een gok
                Console.Write($"Geef een waarde: ");
                int waardeGok = int.Parse(Console.ReadLine());

                Console.Write($"Geef een soort: ");
                string soortGok = Console.ReadLine();

                Console.Write($"Geef een kleur: ");
                string kleurGok = Console.ReadLine();

                Kaart gok = new Kaart(waardeGok, soortGok, kleurGok);

                // controleer of de gok correct is
                if (gok.Equals(kaart))
                {
                    Console.WriteLine("U heeft goed gegokt!");
                    scoreSpeler++;
                }
                else
                {
                    Console.WriteLine($"U heeft niet goed gegokt! De kaart was van de kleur {kaart.Kleur} met een waarde van {kaart.Waarde} en {kaart.Soort} als soort.");
                    scoreComputer++;
                }

                Console.WriteLine($"Computer: {scoreComputer} - Speler: {scoreSpeler}");
                Console.WriteLine();

                // controleer of het spel afgelopen is
                if (scoreComputer == 3)
                {
                    Console.WriteLine("Einde spel. De computer is de winnaar!");
                    break;
                }
                else if (scoreSpeler == 3)
                {
                    Console.WriteLine("Einde spel. De speler is de winnaar!");
                    break;
                }
            }
        }

    }
}
