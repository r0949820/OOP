using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Bmi
    {
        //Atributen
        private string _naam;
        private double _gewicht;
        private double _lengte;

        //Properties
        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }
        public double Gewicht
        {
            get { return _gewicht; }
            set { _gewicht = value; }
        }
        public double Lengte 
        {
            get { return _lengte; }
            set { _lengte = value; }
         }

        //Constructors
        public Bmi(string naam, double weight, double length)
        {
            this.Naam = naam;
            this.Gewicht = weight;
            this.Lengte= length;
        }
        public Bmi() : this ("", 0, 0)
        { }
        

        //Methodes
        public double BerekenBmi()
        {
            return Math.Round(Gewicht / Math.Pow(Lengte, 2), 1);
        }

        public string ToonGegevens()
        {
            return $"{Naam} weegt {Gewicht} kg en is {Lengte} m groot. De BMI is {BerekenBmi()}.";
        }
    }
}
