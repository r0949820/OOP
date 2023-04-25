using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class ElektrischeFormules
    {
        public static double BerekenStroomsterkte(double spanning, double weerstand)
        {
            return Math.Round(spanning / weerstand, 2);
        }

        public static double BerekenSpanning(double stroomsterkte, double weerstand)
        {
            return Math.Round(stroomsterkte * weerstand, 2);
        }

        public static double BerekenWeerstand(double spanning, double stroomsterkte)
        {
            return Math.Round(spanning / stroomsterkte, 2);
        }

        public static double BerekenVermogen(double spanning, double stroomsterkte)
        {
            return Math.Round(spanning * stroomsterkte, 2);
        }
    }
}
