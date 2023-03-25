using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Kat : Dier
    {
        //Properties
        public override string Gegevens
        {
            get { return base.Gegevens + " Miauw! Miauw!"; }
        }

        public Kat(string naam) : base(naam) { }

        // Wanneer een kat praat, zal deze "MAAAUWWW!" als geluid maken.
        public override string Praten(string zin)
        {
            zin = "MAAAUWWW!";
            return zin;
        }

        // Wanneer een kat gestreeld wordt, zal deze "RRR! RRRR! RRRRRRRR!" als geluid maken.
        public override string Strelen()
        {
            string strelen = "RRR! RRRR! RRRRRRRR!";
            return strelen;
        }
    }
}
