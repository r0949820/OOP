using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Persoon
    {
        //Atributen
        private string _voornaam;
        private string _achternaam;

        //properties
        public string Voornaam
        {
            get { return _voornaam; } 
            set { _voornaam = value; }
        }
        public string Achternaam
        {
            get { return _achternaam; } 
            set { _achternaam = value; }
        }
        //Constructor supperklasse
        protected Persoon(string voornaam, string achternaam)
        {
            Voornaam = voornaam;
            Achternaam = achternaam;
        }
        //Methodes
        public virtual string ToonGegevens()
        {
            return $"Mijn naam is {Voornaam} {Achternaam}";
        }
    }
}
