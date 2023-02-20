using System;
using models;

namespace console
{
    public class Program
    {
        static void Main(string[] args)
        {
            string naam, invoer;
            int scoreProgrammeren, scoreNetwerken;
            Student student = new Student();

            do
            {
                Console.Write("Geef een naam: ");
                naam = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(naam));

            do
            {
                Console.Write("Geef een score voor programmeren: ");
                invoer = Console.ReadLine();

            } while (!int.TryParse(invoer, out scoreProgrammeren));
            student.VoerScoreIn(0,scoreProgrammeren);

            do
            {
                Console.Write("Geef een score voor netwerken: ");
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out scoreNetwerken));
            student.VoerScoreIn(1, scoreNetwerken);

            student.Naam = naam;
            student.ScoreProgrammeren = scoreProgrammeren;
            student.ScoreNetwerken= scoreNetwerken;

            Console.WriteLine(student.ToonRapport());
        }
    }
}
