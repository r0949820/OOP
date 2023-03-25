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
            get { return _ibanNummer;} 
            set { _ibanNummer = value; }
        }
        public string LandCode
        //De landcode geeft de eerste 2 karakters van het iban-nummer terug.
        {
            get { return _ibanNummer.Substring(0, 2);}
            set { _landCode = value; }
        }
        public virtual double Minimum
        {
            get { return _minimum; }
            set { _minimum = value; }
        }
        public double Saldo
        {
            //Het saldo mag niet onder minimum komen. Bij foutieve waarde wordt het saldo op het minimum ingesteld.
            get { return _saldo;}
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

        //Constructor
        public Bankrekening(string ibanNummer, double saldo)
        {
            IbanNummer = ibanNummer;
            Saldo = saldo;
        }

        //Methodes
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
    }
}
