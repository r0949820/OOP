using System;
using models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            double b = ReadValue("Breedte: ", -100, 999);
            double l = ReadValue("Lengte: ", -100, 999);
            double d = ReadValue("Diepte: ", -100, 999);
            double r = ReadValue("Randafstand: ", 0, d);

            Zwembad z = new Zwembad(b, d, l, r);

            Console.WriteLine(z.ToonGegevens());
        }

        private static double ReadValue(string name, double min, double max)
        {
            double val;
            string input;

            do
            {
                do
                {
                    Console.Write(name);
                    input = Console.ReadLine();
                } while (double.TryParse(input, out val) == false);
            } while (val < min || val > max);

            return val;
        
    }
    }
}
