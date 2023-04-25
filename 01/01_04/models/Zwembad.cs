using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Zwembad
    {
        private double _breedte;

        public double Breedte
        {
            get { return _breedte; }
            set
            {
                _breedte = value;

                if (value < 0)
                    _breedte = 0;
            }
        }

        private double _diepte;

        public double Diepte
        {
            get { return _diepte; }
            set
            {
                _diepte = value;

                if (value < 0)
                    _diepte = 0;
            }
        }

        private double _lengte;

        public double Lengte
        {
            get { return _lengte; }
            set
            {
                _lengte = value;

                if (value < 0)
                    _lengte = 0;
            }
        }

        private double _randafstand;

        public double Randafstand
        {
            get { return _randafstand; }
            set
            {
                if (value > Diepte)
                    _randafstand = 0;
                else if (value < 0)
                    _randafstand = 0;
                else
                    _randafstand = value;
            }
        }

        public Zwembad(double breedte, double diepte, double lengte, double randafstand)
        {
            Breedte = breedte;
            Diepte = diepte;
            Lengte = lengte;
            Randafstand = randafstand;
        }

        public string ToonGegevens()
        {
            return $"Breedte = {Breedte}\nDiepte = {Diepte}\nLengte = {Lengte}\nRandafstand = {Randafstand}\n\nLiters water = {LiterWater()}";
        }

        public double LiterWater()
        {
            return Breedte * Lengte * (Diepte - Randafstand) * 1000;
        }
    }
}
