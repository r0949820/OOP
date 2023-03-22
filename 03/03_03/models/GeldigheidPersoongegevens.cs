using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class GeldigheidPersoongegevens
    {
        public static string ControleRijksregisternummer(string rijksregisternummer)
        {
            string rijksNr = "";
            bool success = false;
            bool isOK = false;
            long number;

            if (rijksregisternummer.Length == 15)
            {
                char[] rijks = rijksregisternummer.ToCharArray();
                for (int i = 0; i < rijks.Length; i++)
                {
                    if (i == 2 || i == 5 || i == 8 || i == 12)
                    {
                        continue;
                    }
                    rijksNr += rijks[i].ToString();
                }
                success = true;
            }
            if (success && long.TryParse(rijksNr, out number))
            {
                if (long.Parse(rijksNr.Substring(0, 2)) % 2 == 0)
                {
                    isOK = (long)97 - (long.Parse(rijksNr.Substring(0, 9)) % 97) == long.Parse(rijksNr.Substring(9, 2)) ?
                        true : false;
                }
                else
                {
                    isOK = (((long)2000 + long.Parse(rijksNr.Substring(6, 3))) % 20) == long.Parse(rijksNr.Substring(9, 2)) ?
                        true : false;
                }
            }
            return isOK ? $"{rijksregisternummer} (geldig)" : $"{rijksregisternummer} (ongeldig)";
        }
        public static string ControleIban(string iban)
        {
            string ibanNr = "";
            bool success = false;
            bool isOK = false;
            long number;

            if (iban.Length == 14)
            {
                char[] temp = iban.ToCharArray();
                for (int i = 0; i < temp.Length; i++)
                {
                    if (i == 3 || i == 11)
                    {
                        continue;
                    }
                    ibanNr += temp[i].ToString();
                }
                success = true;
            }
            if (success && long.TryParse(ibanNr, out number))
            {
                isOK = long.Parse(ibanNr.Substring(0, 10)) % (long)97 == long.Parse(ibanNr.Substring(10, 2)) ?
                        true : false;
            }

            return isOK ? $"{iban} (geldig)" : $"{iban} (ongeldig)";
        }
        public static bool IsInt(string getal)
        {
            bool success = false;
            int number;
            if (int.TryParse(getal, out number))
            {
                success = true;
            }
            return success;
        }
    }
}
