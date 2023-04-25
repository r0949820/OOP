using System;
using models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            Trein trein = new Trein();

            trein.Opstappen(20);

            trein.DeurOpen = false;

            trein.Versnellen(50);
            trein.Versnellen(50);

            Console.WriteLine(trein.StandVanZaken());

            Console.ReadLine();
        }
    }
}
