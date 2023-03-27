using System;
using System.Collections.Generic;
using System.IO;

namespace models
{
    public static class FileOperations
    {
        public static string BestandSiropen = "siropen.txt";
        public static string BestandToppings = "toppings.txt";
        public static string BestandGlazuren = "glazuren.txt";
        public static string BestandVullingen = "vullingen.txt";
        public static string BestandSmaken = "smaken.txt";

        public static List<string> LeesOpties(string bestandsnaam)
        {
            List<string> opties = new List<string>();
            opties.Insert(0, "Geen");
            if (File.Exists(bestandsnaam))
            {
                using (StreamReader sr = new StreamReader(bestandsnaam))
                {
                    while (!sr.EndOfStream)
                    {
                        string record = sr.ReadLine();
                        opties.Add(record);
                    }
                }
            }
            else
            {
                Console.WriteLine("Bestand niet gevonden!");
            }


            return opties;
        }
    }
}
