using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Werknemer : Persoon
    {
        //Atributen
        private double _loon;

        //Properties
        public double Loon 
        {
            get { return _loon; } 
            set { _loon = value;}
        }

        //Constructor
        public Werknemer(string voornaam, string achternaam) : base(voornaam, achternaam)
        {
            Loon = 10.20;
        }

        //Methodes
        public override string ToonGegevens()
        {
            return base.ToonGegevens() + $" mijn loon bedraagt: {Loon} euro/uur.";
        }
    }
}
