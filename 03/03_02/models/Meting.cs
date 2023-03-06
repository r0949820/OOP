using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace models
{
    public class Meting
    {
        //Atributen
        private DateTime _tijdstip;
        private double _gradenFahrenheit;
        private double _gradenCelsius;

        //Properties
        public DateTime Tijdstip
        {
            get { return _tijdstip; }
            set { _tijdstip = value; }
        }
        public double GradenFahrenheit
        {
            get { return _gradenFahrenheit; }
            set { _gradenFahrenheit = value; }
        }
        public double GradenCelsius
        {
            get { return _gradenCelsius; }
            set { _gradenCelsius = value; }
        }

        //Constructor
        
        public Meting(DateTime tijdstip, double gradenCelsius, double gradenFahrenheit)
        {
            Tijdstip = tijdstip;
            GradenFahrenheit = gradenFahrenheit;
            GradenCelsius = gradenCelsius;
        }
        public Meting(DateTime tijdstip, double gradenCelsius) : this(tijdstip, gradenCelsius, TemperatuurConversies.ConverteerNaarGradenFahrenheit(gradenCelsius))
        {}
        public Meting(double gradenCelsius) : this(DateTime.Now, gradenCelsius, TemperatuurConversies.ConverteerNaarGradenFahrenheit(gradenCelsius))
        {}

        //Methodes
        public string ToonGegevens()
        {
            return $"Meting\n" +
                $"------" +
                $"\n" +
                $"Op {Tijdstip} werd er {GradenCelsius} graden Celsius en {GradenFahrenheit} graden Fahrenheit gemeten.";
        }
    }
}
