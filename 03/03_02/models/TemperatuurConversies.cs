using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace models
{
    public static class TemperatuurConversies
    {
        public static double ConverteerNaarGradenCelsius(double gradenFahrenheit)
        {
            double gradenCelsius = (gradenFahrenheit - 32) * 5 / 9;
            return gradenCelsius;
        }
        public static double ConverteerNaarGradenFahrenheit(double gradenCelsius)
        {
            double gradenFahrenheit = (gradenCelsius * 9 / 5) + 32;
            return gradenFahrenheit;
        }
    }
}
