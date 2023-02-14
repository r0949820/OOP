using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Televisie
    {
        //Deel 1: Atributen
        private int _kanaal;
        private int _volume;

        //Deel 2: Properties
        public int Kanaal
        {
            get { return _kanaal; }
            set {
                if (value < 1)
                {
                    _kanaal = 1;
                }
                if (value > 30)
                {
                    _kanaal = 30;
                }
                else
                {
                    _kanaal = value;
                }
            }
        }
        public int Volume
        {
            get { return _volume; }
            set
            {
                if (value < 0)
                {
                    _volume = 0;
                }
                if (value > 10)
                {
                    _volume = 10;
                }
                else
                {
                    _volume = value;
                }
            }
        }

        //Deel 3: Constructors
        public Televisie()
        {
            Kanaal= 0;
            Volume= 0;
        }

        //Deel 4: Methodes
        
        public void VermeerderKanaal()
        {
            Kanaal++;
        }
        public void VerminderKanaal()
        {
            Kanaal--;
        }
        public void VermeerderVolume()
        {
            Volume++;
        }
        public void VerminderVolume()
        {
            Volume--;
        }
        public string ToonGegevens()
        {
            return $"\nKanaal: {Kanaal}\nVolume: {Volume}";
        }
    }
}
