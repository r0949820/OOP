using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Auto
    {
        //Atributen
        private string _nummerplaat;
        private double _aantalKilometer;
        private double _kostPrijs;
        private double _literBrandstof;

        //Properties

        //Merk is een read only
        protected string Merk
        {
            get { return this.GetType().Name;}
        }

        protected string Nummerplaat
        {
            get { return _nummerplaat; } 
            set { _nummerplaat = value; }
        }

        protected double AantalKilometer
        {
            get { return _aantalKilometer; }
            set { _aantalKilometer = value; }
        }

        protected double KostPrijs
        {
            get { return _kostPrijs; }
            set { _kostPrijs = value; }
        }

        protected double LiterBrandstof
        {
            get { return _literBrandstof; }
            set { _literBrandstof = value; }
        }

        //Constructors
        protected Auto(string nummerplaat, double aantalKilometers, double kostPrijs, double literBrandstof)
        {
            this.Nummerplaat= nummerplaat;
            this.AantalKilometer= aantalKilometers;
            this.KostPrijs= kostPrijs;
            this.LiterBrandstof= literBrandstof;
        }

        //Methodes
        public virtual void Rijden(double aantalKilometer)
        {
            this.AantalKilometer += aantalKilometer;
            this.LiterBrandstof -= (aantalKilometer / 20);
        }

        public override string ToString()
        {
            return $"Ik ben een {this.Merk} met nummerplaat {this.Nummerplaat} " +
                $"({this.AantalKilometer} km - {this.LiterBrandstof:N2} liter)\n" +
                $"Kostprijs: {this.KostPrijs} euro";
        }

        public override bool Equals(object obj)
        {
            if (obj is Auto auto)
            {
                return (this.Nummerplaat == auto.Nummerplaat) && this.GetType() == auto.GetType();
            }

            return false;
        }

        //Overerven en de basemethoden te gebruiken (CodeGrade geeft soms error zonder)
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
