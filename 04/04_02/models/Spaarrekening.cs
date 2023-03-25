using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace models
{
    public class Spaarrekening : Bankrekening
    {
        //Atributen
        private double _percentage;

        //Properties
        public double Percentage
        {
            get { return _percentage; }
            set { _percentage = value; }
        }

        //Constructor
        public Spaarrekening() : base("", 0)
        {
            this.Percentage= 5;
        }

        //Methodes
        public override string ToonGegevens()
        {
            return base.ToonGegevens() + $" (percentage {this.Percentage})";
        }
        public void SchrijfRentebij()
        {
            Saldo = (1 + (Percentage / 100)) * Saldo;
        }
    }
}
