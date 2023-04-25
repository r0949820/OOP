using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Auto
    {
        // attributen
        private string _chassisnummer;
        private string _merk;
        private Motor _motor;

        // properties
        public string Chassisnummer
        {
            get { return _chassisnummer; }
            set { _chassisnummer = value; }
        }
        public string Merk
        {
            get { return _merk; }
            set { _merk = value; }
        }
        public Motor Motor
        {
            get { return _motor; }
            set { _motor = value; }
        }

        // constructor
        public Auto(string chassisnummer, string merk, Motor motor)
        {
            Chassisnummer = chassisnummer;
            Merk = merk;
            Motor = motor;
        }

        // methoden
        public override string ToString()
        {
            return $"De {Merk} met chassisnummer {Chassisnummer} heeft de volgende kenmerken:\n" +
                $"{Motor}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Auto auto)
                return Chassisnummer == auto.Chassisnummer;

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Chassisnummer);
        }

    }
}
