using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Meting
    {
        // Attributes
        private DateTime _tijdstip;
        private double _aantalPond;
        private double _aantalKilo;

        // Properties
        public DateTime Tijdstip
        {
            get { return _tijdstip; }
            set { _tijdstip = value; }
        }

        public double AantalPond
        {
            get { return _aantalPond; }
            set { _aantalPond = value; }
        }

        public double AantalKilo
        {
            get { return _aantalKilo; }
            set { _aantalKilo = value; }
        }

        // Constructors
        public Meting(double aantalKilo) : this(DateTime.Now, GewichtConversies.ConverteerNaarAantalPond(aantalKilo), aantalKilo)
        {

        }

        public Meting(DateTime tijdstip, double aantalKilo) : this(tijdstip, GewichtConversies.ConverteerNaarAantalPond(aantalKilo), aantalKilo)
        {

        }

        public Meting(DateTime tijdstip, double aantalPond, double aantalKilo)
        {
            this.Tijdstip = tijdstip;
            this.AantalPond = aantalPond;
            this.AantalKilo = aantalKilo;
        }

        // Methods
        public string ToonGegevens()
        {
            return $"Op {this.Tijdstip.ToLongDateString()} woog je {this.AantalKilo}kg, wat gelijk is aan {GewichtConversies.ConverteerNaarAantalPond(this.AantalKilo)}lbs.";
        }
    }
}
