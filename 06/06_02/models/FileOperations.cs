using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace models
{
    public class FileOperations
    {
        public static string CursistenBestand = "cursisten.txt";

        public static List<Cursist> LeesCursisten()
        {
            List<Cursist> cursisten = new List<Cursist>();

            if (File.Exists(CursistenBestand))
            {
                using (StreamReader reader = new StreamReader(CursistenBestand))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(';');
                        int cursistId = int.Parse(parts[0]);
                        string voornaam = parts[1];
                        string familienaam = parts[2];

                        cursisten.Add(new Cursist(cursistId, voornaam, familienaam));
                    }
                }
            }

            return cursisten;
        }
        public static void SchrijfCursisten(List<Cursist> cursisten)
        {
            using (StreamWriter sw = new StreamWriter(CursistenBestand))
            {
                foreach (Cursist cursist in cursisten)
                {
                    sw.WriteLine($"{cursist.CursistID},{cursist.Voornaam},{cursist.Familienaam}");
                }
            }
        }

    }
}
