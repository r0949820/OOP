using models;
using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            string invoer;
            int keuze;

            Console.Write("Geef hoeveelheid brandstof: ");
            double brandstof = double.Parse(Console.ReadLine());
            auto.Brandstof = brandstof;

            Console.Write("Geef huidige kilometerstand: ");
            int kilometerstand = int.Parse(Console.ReadLine());
            auto.Kilometerstand = kilometerstand;

            Console.Write("Geef kilometerstand laatste onderhoud: ");
            int kilometerstandOnderhoud = int.Parse(Console.ReadLine());
            auto.KilometerstandOnderhoud = kilometerstandOnderhoud;

            Console.WriteLine("\n" +
                "Opties\n" +
                "---------------\n" +
                "0. Stoppen\n" +
                "1. Voeg 25 kilometer toe\n" +
                "2. Voeg 100 kilometer toe\n" +
                "3. Voeg 1000 kilometer toe\n" +
                "4. Vul brandstof aan\n" +
                "5. Voer onderhoud uit\n");

            do
            {
                Console.Write("Geef een keuze: ");
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out keuze) && (keuze < 0 || keuze > 5));
            
                auto.KeuzeMenu(keuze);
            
                
            
            

            
        }
    }
}
