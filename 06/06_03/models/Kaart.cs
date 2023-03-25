using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Kaart
    {
        public int Waarde { get; }
        public string Soort { get; }
        public string Kleur { get; }

        public Kaart(int waarde, string soort, string kleur)
        {
            Waarde = waarde;
            Soort = soort;
            Kleur = kleur;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Kaart otherKaart = (Kaart)obj;
            return (Waarde == otherKaart.Waarde) && (Soort == otherKaart.Soort) && (Kleur == otherKaart.Kleur);
        }

        public override int GetHashCode()
        {
            return Waarde ^ Soort.GetHashCode() ^ Kleur.GetHashCode();
        }

        public override string ToString()
        {
            return Waarde + " " + Soort + " " + Kleur;
        }
    }
}
