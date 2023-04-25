using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Verwarming
    {
        //Atributen
        private double _graden;
        private bool _aanUit;

        // properties
        public bool AanUit
        {
            get { return _aanUit; }
            set { _aanUit = value; }
        }
        public double Graden
        {
            get { return _graden; }
            set { _graden = value; }
        }

        // Constructor
        public Verwarming()
        {
            Graden = 0;
            AanUit = false;
        }

        public Verwarming(bool aanUit, double graden)
        {
            this.AanUit = aanUit;
            this.Graden = graden;
        }
    }
}
