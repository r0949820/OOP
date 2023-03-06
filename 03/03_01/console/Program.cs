using System;
using models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int optie;
            double lengte, breedte, hoogte, straal;
            optie = VraagOptieOp();

            switch (optie)
            {
                case 0:
                    Console.Write("Geef een lengte: ");
                    lengte= double.Parse(Console.ReadLine());
                    Console.Write("Geef een breedte: ");
                    breedte = double.Parse(Console.ReadLine());
                    double oppervlakteRechthoek = MeetkundigeFormules.OppervlakteRechthoek(lengte, breedte);
                    Console.WriteLine($"De oppervlakte van de rechthoek is: {oppervlakteRechthoek:N2} cm²");
                    break;
                case 1:
                    Console.Write("Geef een straal: ");
                    straal= double.Parse(Console.ReadLine());
                    double oppervlakteCirkel = MeetkundigeFormules.OppervlakteCirkel(straal);
                    Console.WriteLine($"De oppervlakte van de cirkel is: {oppervlakteCirkel:N2} cm²");
                    break;
                case 2:
                    Console.Write("Geef een lengte: ");
                    lengte = double.Parse(Console.ReadLine());
                    Console.Write("Geef een breedte: ");
                    breedte = double.Parse(Console.ReadLine());
                    Console.Write("Geef een hoogte: ");
                    hoogte = double.Parse(Console.ReadLine());
                    double volumeBalk = MeetkundigeFormules.VolumeBalk(lengte, breedte, hoogte);
                    Console.WriteLine($"De volume van de balk is: {volumeBalk:N2} cm²");
                    break;
                case 3:
                    Console.Write("Geef een straal: ");
                    straal = double.Parse(Console.ReadLine());
                    Console.Write("Geef een hoogte: ");
                    hoogte = double.Parse(Console.ReadLine());
                    double volumeCilinder = MeetkundigeFormules.VolumeCilinder(straal, hoogte);
                    Console.WriteLine($"De volume van de cilinder is: {volumeCilinder:N2} cm²");
                    break;
            }
        }
        private static int VraagOptieOp()
        {
            int optie;
            string invoer;
            do
            {
                Console.Write("Opties\r\n------\r\n\r\n0. Oppervlakte rechthoek\r\n1. Oppervlakte cirkel\r\n2. Volume balk\r\n3. Volume cilinder\n\nGeef een optie: ");
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out optie) || optie < 0 || optie > 3);

            return optie;
        }
    }
}
