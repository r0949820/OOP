using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Zoetigheid
    {
        //Atributen
        private string _siroop;
        private string _topping;

        //Properties
        public string Siroop
        {
            get { return _siroop; }
            set { _siroop = value; }
        }
        public string Topping
        {
            get { return _topping; }
            set { _topping = value; }
        }

        //Constructor
        protected Zoetigheid(string siroop, string topping)
        {
            Siroop= siroop;
            Topping= topping;
        }

        //Methodes
        public virtual double BerekenPrijs()
        {
            double siroop = 1;
            double topping = 1.5;
            double totaalPrijs = siroop + topping;
            return totaalPrijs;
        }
        public virtual string ToonOverzicht()
        {
            return $"Topping: {Topping}\nSiroop: {Siroop}";
        }
    }
}
