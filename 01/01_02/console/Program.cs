using models;
using System;

namespace console
{
   internal class Program
    {
        static void Main(string[] args)
        {
            Televisie televisie = new Televisie();
            int kanaal, volume, keuze = 0;

            do
            {
                Console.Write("Geef een kanaal tussen 1 & 30: ");
                kanaal = int.Parse(Console.ReadLine());
            } while (kanaal < 1 || kanaal > 30);
            
            
            televisie.Kanaal = kanaal;

            do
            {
                Console.Write("Geef een het volume tussen 0 & 10: ");
                volume = int.Parse(Console.ReadLine());
            } while (volume < 0 || volume > 10);
            

            televisie.Volume= volume;

            Console.WriteLine("1: Kanaal verhogen \n2: Kanaal verlagen \n3: Volume verhogen \n4: Volume verlagen \n5: Stoppen");
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

                Console.WriteLine("1: Kanaal verhogen \n2: Kanaal verlagen \n3: Volume verhogen \n4: Volume verlagen \n5: Stoppen");
                keuze = int.Parse(Console.ReadLine());
            }
           
                Console.WriteLine(televisie.ToonGegevens());
            
        }
    }
}
