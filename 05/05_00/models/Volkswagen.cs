using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Volkswagen : Auto
    {
        public Volkswagen(string nummerplaat, double aantalKilometers, double kostPrijs, double literBrandstof)
        : base(nummerplaat, aantalKilometers, kostPrijs, literBrandstof)
        { }

        public override void Rijden(double aantalKilometer)
        {
            this.AantalKilometer += aantalKilometer;
            this.LiterBrandstof -= (aantalKilometer / 25);
        }
    }
}
