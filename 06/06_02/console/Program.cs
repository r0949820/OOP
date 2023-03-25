using System;
using System.Collections.Generic;
using models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lees de lijst van cursisten in uit het bestand
            List<Cursist> cursisten = FileOperations.LeesCursisten();

            // Toon het menu en verwerk de keuze van de gebruiker
            int keuze = -1;
            while (keuze != 2)
            {
                Console.Clear();
                Console.WriteLine("Cursisten\n---------");
                PrintCursisten(cursisten);
                Console.WriteLine("\nWat wil je doen?\n\n0. Toevoegen\n1. Verwijderen\n2. Afsluiten");
                keuze = PrintOptions();

                switch (keuze)
                {
                    case 0:
                        AddCursist(cursisten);
                        break;
                    case 1:
                        DeleteCursist(cursisten);
                        break;
                    case 2:
                        // Schrijf de bijgewerkte lijst van cursisten weg naar het bestand
                        FileOperations.SchrijfCursisten(cursisten);
                        break;
                    default:
                        Console.WriteLine("Ongeldige keuze. Druk op Enter om opnieuw te proberen.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static int PrintOptions()
        {
            Console.Write("Maak een keuze: ");
            int keuze;
            while (!int.TryParse(Console.ReadLine(), out keuze))
            {
                Console.Write("Ongeldige keuze. Probeer opnieuw: ");
            }
            return keuze;
        }

        static void AddCursist(List<Cursist> cursisten)
        {
            Console.Clear();
            Console.Write("Geef de voornaam van de nieuwe cursist: ");
            string voornaam = Console.ReadLine();
            Console.Write("Geef de familienaam van de nieuwe cursist: ");
            string familienaam = Console.ReadLine();

            // Bepaal de hoogste cursistId in de lijst en tel daar 1 bij op voor de nieuwe cursistId
            int nieuweCursistId = 1;
            foreach (Cursist cursist in cursisten)
            {
                if (cursist.CursistID >= nieuweCursistId)
                {
                    nieuweCursistId = cursist.CursistID + 1;
                }
            }

            // Voeg de nieuwe cursist toe aan de lijst
            Cursist nieuweCursist = new Cursist(nieuweCursistId, voornaam, familienaam);
            cursisten.Add(nieuweCursist);

            Console.Clear();
            Console.WriteLine("Nieuwe lijst van cursisten\n--------------------------");
            PrintCursisten(cursisten);
            Console.WriteLine("\nDruk op Enter om verder te gaan.");
            Console.ReadLine();
        }
        static void DeleteCursist(List<Cursist> cursisten)
        {
            Console.Clear();
            PrintCursisten(cursisten);

            Console.Write("Geef de cursistId van de cursist die je wil verwijderen: ");
            int cursistIdToDelete = 0;
            while (!int.TryParse(Console.ReadLine(), out cursistIdToDelete))
            {
                Console.Write("Geef een geldig getal als cursistId: ");
            }

            // Zoek de cursist om te verwijderen op basis van de ingevoerde cursistId
            int indexToDelete = -1;
            for (int i = 0; i < cursisten.Count; i++)
            {
                if (cursisten[i].CursistID == cursistIdToDelete)
                {
                    indexToDelete = i;
                    break;
                }
            }

            if (indexToDelete == -1)
            {
                Console.WriteLine($"Er bestaat geen cursist met cursistId {cursistIdToDelete}");
            }
            else
            {
                if (cursisten[indexToDelete].CursistID == 1)
                {
                    Console.WriteLine("Je kan de eerste cursist niet verwijderen.");
                }
                else
                {
                    cursisten.RemoveAt(indexToDelete);

                    // Bijwerken van de cursistIds
                    for (int i = indexToDelete; i < cursisten.Count; i++)
                    {
                        cursisten[i].CursistID--;
                    }

                    Console.WriteLine("Cursist succesvol verwijderd.");
                    Console.WriteLine();
                    PrintCursisten(cursisten);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Druk op Enter om verder te gaan...");
            Console.ReadLine();
        }
        static void PrintCursisten(List<Cursist> cursisten)
        {
            Console.WriteLine("\nLijst van cursisten\n-------------------");
            foreach (Cursist cursist in cursisten)
            {
                Console.WriteLine($"{cursist.CursistID}. {cursist.Naam}");
            }
            Console.WriteLine();
        }

    }

}
