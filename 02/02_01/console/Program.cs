using System;
using models;

namespace console
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vierkant vierkant= new Vierkant();

            Console.Write("Geef een zijde: ");
            int zijde = int.Parse(Console.ReadLine());

            vierkant.Zijde = zijde;

            Console.WriteLine($"Teken:\n" +
                $"{vierkant.Teken()}\n" +
                $"" +
                $"Omtrek: {vierkant.Omtrek()}\n" +
                $"Oppervlakte: {vierkant.Oppervlakte()}\n" +
                $"Diagonaal: {vierkant.Diagonaal()}");
            
        }
    }
}
