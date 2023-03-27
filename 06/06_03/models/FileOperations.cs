using System;
using System.Collections.Generic;
using System.IO;

namespace models
{
    public class FileOperations
    {
        public static List<Kaart> LeesFile(string filenaam)
        {
            List<Kaart> kaarten = new List<Kaart>();
            if (File.Exists(filenaam))
            {
                using (StreamReader streamreader = new StreamReader(filenaam))
                {
                    while (!streamreader.EndOfStream)
                    {
                        string record = streamreader.ReadLine();
                        string[] data = record.Split(';');
                        int.TryParse(data[0], out int waarde);
                        string soort = data[1];
                        string kleur = data[2];
                        Kaart kaart = new Kaart(waarde, soort, kleur);
                        kaarten.Add(kaart);
                    }
                }
            }
            else
            {
                Console.WriteLine("Bestand niet gevonden!");
            }
            return kaarten;
        }
    }
}
