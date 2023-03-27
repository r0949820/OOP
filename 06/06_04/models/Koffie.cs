using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Koffie : Zoetigheid
    {
        private string _smaak;
        private bool _slagroom;

        public string Smaak
        {
            get { return _smaak; }
            set { _smaak = value; }
        }
        public bool Slagroom
        {
            get { return _slagroom; }
            set { _slagroom = value; }
        }

        public Koffie(string siroop, string topping, string smaak, bool metSlagroom) : base(siroop, topping)
        {
            Smaak = smaak;
            Slagroom = metSlagroom;
        }

        public override double BerekenPrijs()
        {
            double prijs = 3.5; // standaardprijs van een koffie

            // extra kosten voor glazuur en vulling
            if (Slagroom)
            {
                prijs += 0.5;
                
            }

            // voeg kosten voor topping en siroop toe
            if (Topping != "Geen")
            {
                prijs += 1.5;
            }

            if (Siroop != "Geen")
            {
                prijs += 1.0;
            }

            return prijs;
        }
        public override string ToonOverzicht()
        {
            string overzicht = $"Type: {GetType().Name}\n{base.ToonOverzicht()}";

            overzicht += $"\nSmaak: {Smaak}\nMet slagroom: {(Slagroom ? "Ja" : "Nee")}\nPrijs: {BerekenPrijs():N2} euro\n";

            return overzicht;
        }
        public override string ToString()
        {
            return $"{GetType().Name} => {BerekenPrijs()} euro";
        }
    }
}
