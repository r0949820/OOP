using System;
using System.Collections.Generic;
using models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Auto> autos = new List<Auto>();
            PrintOverzicht(autos);
            int keuze = LeesKeuze();

            while (keuze != 3)
            {
                switch (keuze)
                {
                    case 1:
                        Console.Write("Geef het chassisnummer: ");
                        string chassisnummer = Console.ReadLine();
                        Console.Write("Geef het merk: ");
                        string merk = Console.ReadLine();
                        Console.Write("Geef de cilinderinhoud: ");
                        int cilinderinhoud = int.Parse(Console.ReadLine());
                        Console.Write("Geef het aantal PK: ");
                        int pk = int.Parse(Console.ReadLine());
                        Motor motor = new Motor(cilinderinhoud, pk);
                        Auto auto = new Auto(chassisnummer, merk, motor);
                        if (!autos.Contains(auto))
                        {
                            autos.Add(auto);
                        }
                        break;
                    case 2:
                        Console.Write("Geef het chassisnummer: ");
                        string chassisnummer2 = Console.ReadLine();
                        foreach (Auto auto2 in autos)
                        {
                            if (auto2.Chassisnummer == chassisnummer2)
                            {
                                autos.Remove(auto2);
                                break;
                            }
                        }
                        break;
                }
                PrintOverzicht(autos);
                keuze = LeesKeuze();
            }
        }
        private static void PrintOverzicht(List<Auto> autos)
        {
            string titel = "Jouw auto's";
            Console.WriteLine(titel);
            Console.WriteLine(new String('-', titel.Length));

            if (autos.Count == 0)
            {
                Console.WriteLine("Er zijn nog geen auto's.");
                return;
            }
            for (int i = 0; i < autos.Count; i++)
            {
                Console.WriteLine($"{i + 1}, {autos[i]}");
            }
        }
        private static int LeesKeuze()
        {
            Console.WriteLine("" +
                "1. Auto toeveogen\n" +
                "2. Auto verwijderen\n" +
                "3. Afsluiten");
            int keuze = int.Parse(Console.ReadLine());
            return keuze;
        }
    }
    
}
