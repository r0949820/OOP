using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Cursist
    {
        public int CursistID { get; set; }
        public string Voornaam { get; set; }
        public string Familienaam { get; set; }

        public string Naam
        {
            get { return $"{Voornaam} {Familienaam}"; }
        }

        public Cursist(int cursistId, string voornaam, string familienaam)
        {
            CursistID = cursistId;
            Voornaam = voornaam;
            Familienaam = familienaam;
        }

        public override string ToString()
        {
            return $"{CursistID}. {Naam}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Cursist other = (Cursist)obj;
            return CursistID == other.CursistID;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(CursistID, Voornaam, Familienaam, Naam);
        }
    }
}
