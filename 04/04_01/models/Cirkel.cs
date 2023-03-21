using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Cirkel : Punt
    {
        //Atributen
        private double _r;

        //Properties
        public double R
        {
            get { return _r; }
            set { _r = value; }
        }
        public override string Omschrijving
        {
            get { return $"{this.GetType().Name}: coord=({X},{Y}) straal {R}"; }
        }
        //Constructor
        public Cirkel(double x, double y, double r): base (x,y)
        {
            this.R= r;
        }
        public Cirkel()
        {}

        //Methoden
        public double Omtrek()
        {
            return Math.Round(2 * Math.PI * R, 2);
        }

        
        public override string ToonGegevens()
        {
            return base.ToonGegevens() + $"\nOppervlakte: {Oppervlakte()}\nOmtrek: {Omtrek()}";
        }
        public virtual double Oppervlakte()
        {
            return Math.Round(Math.PI * (R * R), 2);
        }
    }
}
