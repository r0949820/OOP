using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class BMW : Auto
    {
        public BMW(string nummerplaat, double aantalKilometers, double kostPrijs, double literBrandstof)
        : base(nummerplaat, aantalKilometers, kostPrijs, literBrandstof)
        { }

        public override void Rijden(double aantalKilometer)
        {
            base.Rijden(aantalKilometer);
        }
    }
}
