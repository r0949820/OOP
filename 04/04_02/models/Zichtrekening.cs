using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Zichtrekening : Bankrekening
    {
        public Zichtrekening(string rekeningnr, double saldo) : base(rekeningnr, saldo)
        {
            this.Minimum = -100;
        }

        public override string ToonGegevens()
        {
            return base.ToonGegevens() + $" (Minimum {Minimum})";
        }
    }
}
