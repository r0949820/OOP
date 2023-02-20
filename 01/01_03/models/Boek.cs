using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Boek
    {
        private string _titel;
        private string _auteur;
        private int _bladzijden;
        private double _dagen;
        private int _bladzijdenPerDag;

        public string Titel
        {
            get { return _titel; }
            set { _titel = value; }
        }

        public string Auteur
        {
            get { return _auteur; }
            set { _auteur = value; }
        }

        public int Bladzijden
        {
            get { return _bladzijden; }
            set { _bladzijden = value; }
        }

        public double Dagen
        {
            get { return _dagen; }
            set { _dagen = value; }
        }

        public int BladzijdenPerDag
        {
            get { return _bladzijdenPerDag; }
            set { _bladzijdenPerDag = value; }
        }

        public Boek()
        {
            Titel = "";
            Auteur = "";
            Bladzijden = 0;
            Dagen = 0;
            BladzijdenPerDag = 0;
        }


        
        public double Berekening(double Bladzijden, double BladzijdenPerDag)
        {
            double dagen;

            dagen = Bladzijden / BladzijdenPerDag;
            
            
            
            return Math.Ceiling(dagen);
        }

        public string ToonGegevens()
        {
            return $"Het boek {Titel} van {Auteur} zou {Dagen} dagen duren om uit te lezen.";
        }

    }
}
