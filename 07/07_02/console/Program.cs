using System;
using System.Collections.Generic;
using System.IO;
using models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vraag de gebruiker om informatie over de verzender
            string voornaam, familienaam, emailadres;

            do
            {
                Console.Write("Geef voornaam: ");
                voornaam = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(voornaam));

            do
            {
                Console.Write("Geef achternaam: ");
                familienaam = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(familienaam));

            do
            {
                Console.Write("Geef emailadres: ");
                emailadres = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(emailadres));

            Persoon verzender = new Persoon(voornaam, familienaam, emailadres);

            // Lees de contacten in vanuit het bestand en voeg ze toe aan een lijst
            List<Persoon> ontvangers = new List<Persoon>();
            using (StreamReader sr = new StreamReader("contacten.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(';');
                    string Voornaam = fields[0];
                    string Familienaam = fields[1];
                    string ontvangerEmail = fields[2];
                    Persoon p = new Persoon(Voornaam, Familienaam, ontvangerEmail);
                    ontvangers.Add(p);
                }
            }

            // Vraag gebruiker om ontvanger te kiezen
            int index;
            do
            {
                for (int i = 0; i < ontvangers.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {ontvangers[i]}");
                }

                Console.Write("Kies ontvanger: ");

            } while (!int.TryParse(Console.ReadLine(), out index) || index < 1 || index > ontvangers.Count);

            Persoon ontvanger = ontvangers[index - 1];


            // Vraag gebruiker om bericht op te stellen
            Console.Write("Geef titel: ");
            string titel = Console.ReadLine();

            Console.Write("Geef bericht: ");
            string bericht = Console.ReadLine();

            // Maak en verstuur email
            Email email = new Email(verzender, ontvanger, titel, bericht);
            email.Verstuur();

            
        }
    }
}
