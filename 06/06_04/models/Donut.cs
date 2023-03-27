using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Donut : Zoetigheid
    {
        //Atributen
        private string _glazuur;
        private string _vulling;
        //Properties
        public string Glazuur
        {
            get { return _glazuur; }
            set { _glazuur = value;}
        }
        public string Vulling
        {
            get { return _vulling; }
            set { _vulling = value;}
        }

        //Constructor
        public Donut(string siroop, string topping,string glazuur, string vulling) : base(siroop, topping)
        {
            Glazuur = glazuur;
            Vulling = vulling;
        }

        //Methodes
        public override double BerekenPrijs()
        {
            double prijs = 2.0; // standaardprijs van een donut

            // extra kosten voor glazuur en vulling
            if (Glazuur != "Geen")
            {
                prijs += 0.5;
            }

            if (Vulling != "Geen")
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

            overzicht += $"\nGlazuur: {Glazuur}\nVulling: {Vulling}\nPrijs: {BerekenPrijs():N2} euro\n";

            return overzicht;
        }
        public override string ToString()
        {
            return $"{GetType().Name} => {BerekenPrijs()} euro";
        }
    }
}
