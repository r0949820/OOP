using System;
using models;


namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime tijdstip = DateTime.MinValue;
            double aantalKilo;
            Meting meting;

            tijdstip = LeesMeetmomentIn();

            aantalKilo = LeesAantalKiloIn();

            meting = new Meting(tijdstip, aantalKilo);

            Console.WriteLine(Environment.NewLine + meting.ToonGegevens());

            Console.ReadLine();
        }

        private static DateTime LeesMeetmomentIn()
        {
            DateTime tijdstip;
            string invoer;

            do
            {
                Console.Write("Geef een datum in: ");
                invoer = Console.ReadLine();
            } while (!DateTime.TryParse(invoer, out tijdstip));

            return tijdstip;
        }

        private static double LeesAantalKiloIn()
        {
            double aantalKilo;
            string invoer;

            do
            {
                Console.Write("Geef je huidig gewicht in: ");
                invoer = Console.ReadLine();
            } while (!double.TryParse(invoer, out aantalKilo) && aantalKilo < 1);

            return aantalKilo;
        }
    }
}
