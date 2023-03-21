using System;
using models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaratie variabelen
            Punt punt;
            Cirkel cirkel;
            Cilinder cilinder;

            

            // maak keuze
            Console.WriteLine("0. Punt\n" +
                "1. Cirkel\n" +
                "2. Cilinder");

            Console.Write("Maak uw keuze: ");
            int keuze = int.Parse(Console.ReadLine());

            switch (keuze)
            {
                case 0:
                    punt = new Punt(GeefWaarde(), GeefWaarde());
                    Console.WriteLine(punt.ToonGegevens());
                    break;
                case 1:
                    cirkel = new Cirkel(GeefWaarde(), GeefWaarde(), GeefWaarde());
                    Console.WriteLine(cirkel.ToonGegevens());
                    break;
                case 2:
                    cilinder = new Cilinder(GeefWaarde(), GeefWaarde(), GeefWaarde(), GeefWaarde());
                    Console.WriteLine(cilinder.ToonGegevens());
                    break;
            }
            
        }
        private static double GeefWaarde()
        {
            string input = "";
            double waarde = 0;
            bool succes = false;
            do
            {
                Console.Write("Geef een waarde: ");
                input = Console.ReadLine();
                succes = double.TryParse(input, out waarde);
                if (waarde <= 0)
                {
                    succes = false;
                }
            } while (!succes);
            return waarde;
        }
    }
    }


