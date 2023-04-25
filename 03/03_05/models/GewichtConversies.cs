using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public static class GewichtConversies
    {
        public static double ConverteerNaarAantalPond(double kilogram)
        {
            return Math.Round(kilogram * 2.204, 2);
        }

        public static double ConverteerNaarAantalKilo(double pond)
        {
            return Math.Round(pond * 0.453, 2);
        }
    }
    }
