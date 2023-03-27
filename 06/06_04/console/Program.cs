using models;
using System;
using System.Collections.Generic;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Laad de lijsten van opties in
            List<string> siroop = FileOperations.LeesOpties(FileOperations.BestandSiropen);
            List<string> topping = FileOperations.LeesOpties(FileOperations.BestandToppings);
            List<string> smaken = FileOperations.LeesOpties(FileOperations.BestandSmaken);
            List<string> glazuur = FileOperations.LeesOpties(FileOperations.BestandGlazuren);
            List<string> vullingen = FileOperations.LeesOpties(FileOperations.BestandVullingen);

            //Vraagt aan de gebruiker of het donut of koffie is
            Console.WriteLine("0. Donut");
            Console.WriteLine("1. Koffie");
            Console.Write("\nGeef een optie op: ");
            string keuze = Console.ReadLine().ToLower();

            if (keuze == "donut")
            {
                Console.WriteLine();
                // Vraag de gebruiker om hun keuzes te maken voor de donut
                // Geef de opties weer en vraag om een keuze voor elk van de opties
                int siroopKeuze = ToonOptiesEnVraagKeuze(siroop, "siroop");
                int toppingKeuze = ToonOptiesEnVraagKeuze(topping, "topping");
                int glazuurKeuze = ToonOptiesEnVraagKeuze(glazuur, "glazuur");
                int vullingKeuze = ToonOptiesEnVraagKeuze(vullingen, "vulling");
                Console.WriteLine();

                // Maak een nieuwe Donut instantie met de gekozen siroop, topping, glazuur en vulling
                Donut donut = new Donut(siroop[siroopKeuze], topping[toppingKeuze], glazuur[glazuurKeuze], vullingen[vullingKeuze]);

                // Print de bestellingsoverzicht van de aangemaakte donut
                ToonBestelling(donut.ToonOverzicht());
            }
            else if (keuze == "koffie")
            {
                Console.WriteLine();
                // Vraag de gebruiker om hun keuzes te maken voor de koffie
                // Geef de opties weer en vraag om een keuze voor elk van de opties
                int siroopKeuze = ToonOptiesEnVraagKeuze(siroop, "siroop");
                int toppingKeuze = ToonOptiesEnVraagKeuze(topping, "topping");
                int smakenKeuze = ToonOptiesEnVraagKeuze(smaken, "smaak");
                bool metSlagroom = VraagJaOfNee("Wenst u slagroom: ");

                // Maak een nieuwe Koffie instantie met de gekozen siroop, toppings, smaken en metSlagroom
                Koffie koffie = new Koffie(siroop[siroopKeuze], topping[toppingKeuze], smaken[smakenKeuze], metSlagroom);

                // Print de bestellingsoverzicht van de aangemaakte Koffie
                ToonBestelling(koffie.ToonOverzicht());
            }
            }
        private static int ToonOptiesEnVraagKeuze(List<string> opties, string optieNaam)
        {
            //De for-lus loopt door de lijst en toont de index en de naam.
            //Vervolgens wordt de gebruiker gevraagd om te kiezen door een nummer in te voeren. 
            //De keuze van de gebruiker wordt opgeslagen in een variabele.
            for (int i = 0; i < opties.Count; i++)
            {
                Console.WriteLine($"{i}. {opties[i]}");
            }
            Console.WriteLine();
            Console.Write($"Kies een {optieNaam}: ");
            int keuze = int.Parse(Console.ReadLine());
            Console.WriteLine();
            return keuze;
        }
        private static bool VraagJaOfNee(string vraag)
        {
            Console.Write(vraag);
            string antwoord = Console.ReadLine().ToLower();
            return (antwoord == "ja");
        }
        private static void ToonBestelling(string bestellingsoverzicht)
        {
            Console.WriteLine($"\nBedankt voor uw bestelling!\n" +
                               $"\nUw bestelling:\n" +
                               $"{bestellingsoverzicht}");
        }
    }
}
