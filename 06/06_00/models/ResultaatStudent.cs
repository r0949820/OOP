using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class ResultaatStudent
    {
        //Atributen
        private string _naam;
        private double _punten;

        //Properties
        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }
        public double Punten
        {
            get { return _punten; }
            set { _punten = value; }
        }

        public string Resultaat
        {
            get
            {
                if (Punten < 50)
                {
                    return "Niet geslaagd!";
                }
                else
                {
                    return "Geslaagd!";
                }
            }
        }

        //Constructor
        public ResultaatStudent(string naam, double punten)
        {
            Naam = naam;
            Punten = punten; 
        }

        public ResultaatStudent() : this("", 0)
        { }

        public override string ToString()
        {
            return $"{Naam} {Punten:N2} {Resultaat}";
        }
    }
}
