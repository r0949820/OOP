using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class TvKanaal
    {
        //atributen
        private int _nummer;
        private string _omschrijving;

        //properties
        public int Nummer 
        {
            get { return _nummer; }
            set { _nummer = value; }
        }
        public string Omschrijving
        {
            get { return _omschrijving; }
            set { _omschrijving = value; }
        }
        //Constructor
        public TvKanaal(int nummer, string omschrijving)
        {
            Nummer = nummer;
            Omschrijving = omschrijving;
        }
        public TvKanaal() : this(0, "")
        { }

        //Methode
        public override string ToString()
        {
            return $"Nummer van het kanaal is {Nummer}";
        }
    }
}
