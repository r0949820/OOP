using models;
using System;

namespace console
{
   internal class Program
    {
        static void Main(string[] args)
        {
            Televisie televisie = new Televisie();
            int keuze = 0;

            

            Console.WriteLine($"Startconfiguratie: Kanaal: {televisie.Kanaal} - Volume {televisie.Volume}");

            Console.Write("Maak een keuze: ");
            keuze= int.Parse(Console.ReadLine());

            while (keuze != 5)
            {
                if (keuze == 1)
                {
                    televisie.VermeerderKanaal();
                }
                else if (keuze == 2)
                {
                    televisie.VerminderKanaal();
                }
                else if (keuze == 3)
                {
                    televisie.VermeerderVolume();
                }
                else if (keuze == 4)
                {
                    televisie.VerminderVolume();
                }

                Console.Write("Maak een keuze: ");
                keuze = int.Parse(Console.ReadLine());
            }
           
                Console.WriteLine(televisie.ToonGegevens());
            
        }
    }
}
