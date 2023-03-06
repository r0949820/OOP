using System;
using models;

namespace console
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime tijdstip = DateTime.Now;
            Meting meting;

            Console.Write("Geef aantal graden Celsius: ");
            double gradenCelsius = double.Parse(Console.ReadLine());
            

            Console.Write("Geef aantal graden Fahrenheit: ");
            string gradenFahrenheitS = Console.ReadLine();

            
            Console.Write("Geef een tijdstip: ");
            string tijdstipS = Console.ReadLine();

            if (gradenFahrenheitS != "")
            {
                double.TryParse(gradenFahrenheitS, out double gradenFahrenheit);
                meting = new Meting(tijdstip, gradenCelsius, gradenFahrenheit);
                meting.GradenCelsius = gradenCelsius;
                meting.GradenFahrenheit = gradenFahrenheit;
                meting.Tijdstip = tijdstip;
            }
            else if (tijdstipS != "")
            {
                DateTime.TryParse(tijdstipS, out tijdstip);
                meting = new Meting(tijdstip, gradenCelsius);
                meting.GradenCelsius = gradenCelsius;
                meting.Tijdstip = tijdstip;
            }
            else
            {
                meting = new Meting(gradenCelsius);
                meting.GradenCelsius = gradenCelsius;
            }
            


            Console.WriteLine(meting.ToonGegevens());


        }
    }
}
