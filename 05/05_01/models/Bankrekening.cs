using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Bankrekening
    {
        //Atributen
        private string _ibanNummer;
        private string _landCode;
        private double _minimum;
        private double _saldo;

        //Properties
        public string IbanNummer
        {
            get { return _ibanNummer; }
            set { _ibanNummer = value; }
        }

        // De landcode geeft de eerste 2 karakters van het iban-nummer terug.
        public string LandCode
        {
            get { return _ibanNummer.Substring(0, 2); }
            set { _landCode = value; }
        }

        public virtual double Minimum
        {
            get { return _minimum; }
            set { _minimum = value; }
        }

        
        public double Saldo
        {
            get { return _saldo; }
            set
            {
                if (value < Minimum)
                {
                    _saldo = Minimum;
                }
                else
                {
                    _saldo = value;
                }
            }
        }
        //Methodes
        public Bankrekening(string ibanNummer, double saldo)
        {
            IbanNummer = ibanNummer;
            Saldo = saldo;
        }

        public void Afhalen(double bedrag)
        {
            Saldo -= bedrag;
        }

        public void Storten(double bedrag)
        {
            Saldo += bedrag;
        }

        public virtual string ToonGegevens()
        {
            return $"Rekening {IbanNummer} met saldo {Saldo}";
        }

        // Geeft de tekstuele voorstelling van het object als volgt:
        // <IbanNummer> -> Je huidig saldo bedraagt: <Saldo> euro.
        public override string ToString()
        {
            return $"{IbanNummer} -> Je huidig saldo bedraagt: {Saldo} euro.";
        }
    }
}
