using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Motor
    {
        // attributen
        private int _cilinderinhoud;
        private int _pk;

        // properties
        public int Cilinderinhoud
        {
            get { return _cilinderinhoud; }
            set { _cilinderinhoud = value; }
        }
        public int Pk
        {
            get { return _pk; }
            set { _pk = value; }
        }

        // constructor
        public Motor(int cilinderinhoud, int pk)
        {
            this.Cilinderinhoud = cilinderinhoud;
            this.Pk = pk;
        }

        // methoden
        public override string ToString()
        {
            return $"Cilinderinhoud: {Cilinderinhoud} - PK: {Pk}";
        }
    }
}

