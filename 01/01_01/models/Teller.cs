using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Teller
    {
        //Deel 1: Atributen
        private int _waarde;

        //Deel 2: Properties
        public int Waarde
        {
            get { return _waarde; }
            set { _waarde = value; }
        }

        //Deel 3: Constructors
        public Teller()
        {
            Waarde = 0;
        }

        //Deel 4: Methodes
        public void Verhoog()
        {
            Waarde++;
        }

        public void Verlaag()
        {
            Waarde--;
        }

        public void Resetten()
        {
            Waarde = 0;
        }

        public string ToonGegevens()
        {
            return $"De waarde van de teller is {Waarde}.";
        }
    }
}
