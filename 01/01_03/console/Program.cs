using System;
using models;

namespace console
{
    public class Program
    {
        static void Main(string[] args)
        {
            Boek boek= new Boek();

            Console.Write("Titel: ");
            string titel = Console.ReadLine();
            Console.Write("Auteur: ");
            string auteur = Console.ReadLine();
            Console.Write("Bladzijden: ");
            int bladzijden = int.Parse(Console.ReadLine());
            Console.Write("Bladzijden per dag: ");
            int bladzijdenPerDag = int.Parse(Console.ReadLine());

            boek.Titel= titel;
            boek.Auteur= auteur;
            boek.Bladzijden= bladzijden;
            boek.BladzijdenPerDag = bladzijdenPerDag;

            
            boek.Dagen = boek.Berekening(Bladzijden: bladzijden, BladzijdenPerDag: bladzijdenPerDag);

            Console.WriteLine(boek.ToonGegevens());
        }
    }
}
