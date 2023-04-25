using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Licht
    {
        // Atributen
        private bool _aanUit;

        // Propertie
        public bool AanUit
        {
            get { return _aanUit; }
            set { _aanUit = value; }
        }

        // CTOR
        public Licht()
        {
            AanUit = false;
        }
    }
}
