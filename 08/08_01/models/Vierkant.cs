using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace models
{
    public class Vierkant
    {
        //Atributen
        private int _zijde;

        //Properties
        public int Zijde
        {
            get { return _zijde; }
            set
            {
                if (value < 0)
                {
                    _zijde = 0;
                }
                else if (value > 25)
                {
                    _zijde = 25;
                }
                else
                {
                    _zijde = value;
                }
            }
        }

        //Constructor
        public Vierkant(int lengte)
        {
            Zijde = lengte;
        }
        public Vierkant() : this(0)
        { }

        //Methodes
        public int Oppervlakte()
        {
            return Zijde * Zijde;
        }
        public int Omtrek()
        {
            return 4 * Zijde;
        }
        public double Diagonaal()
        {
            return Math.Round(Math.Sqrt(2) * Zijde, 2);
        }
        public string Teken()
        {
            string teken = "";

            for (int i = 0; i < Zijde; i++)
            {
                for (int j = 0; j < Zijde; j++)
                {
                    teken += "* ";
                }
                teken += "\n";

            }


            return teken;
        }
    }
}
