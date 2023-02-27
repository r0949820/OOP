using System;
using models;

namespace console
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bmi bmi = new Bmi();

            string naam, invoer;
            double gewicht, lengte;

            do
            {
                Console.Write("Geef een naam: ");
                naam = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(naam));

            do
            {
                Console.Write("Geef een gewicht: ");
                invoer= Console.ReadLine();
            } while (!double.TryParse(invoer, out gewicht));

            do
            {
                Console.Write("Geef een lengte: ");
                invoer = Console.ReadLine();
            } while (!double.TryParse(invoer, out lengte));

            bmi.Naam = naam;
            bmi.Lengte= lengte;
            bmi.Gewicht= gewicht;

            Console.WriteLine(bmi.ToonGegevens());
        }
    }
}
