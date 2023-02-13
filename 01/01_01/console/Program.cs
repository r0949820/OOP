using System;
using models;

namespace console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaratie en initialisatie van object
            Teller teller = new Teller();

            //Waardes opvragen
            Console.Write("Geef een keuze in van 0 tot 3: ");
            int waarde = int.Parse(Console.ReadLine());

            //Gegevens toekenen aan object
            while (waarde != 0)
            {
                if (waarde == 1)
                {
                    teller.Verhoog();
                }
                else if (waarde == 2)
                {
                    teller.Verlaag();
                }
                else if (waarde == 3)
                {
                    teller.Resetten();
                }
                Console.Write("Geef een keuze in van 0 tot 3: ");
                waarde = int.Parse(Console.ReadLine()) ;
            }

           
            Console.WriteLine(teller.ToonGegevens());


        }
    }
}
