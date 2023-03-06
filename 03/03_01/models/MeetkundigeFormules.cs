using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public static class MeetkundigeFormules
    {
        //Atributen
        public static double Rechthoek;
        public static double Cirkel;
        public static double Balk;
        public static double Cilinder;

        //Methodes
        public static double OppervlakteRechthoek(double lengte, double breedte)
        {
            double oppervlakteRechthoek = lengte * breedte;
            return oppervlakteRechthoek;
        }

        public static double OppervlakteCirkel(double straal)
        {
            double oppervlakteCirkel = Math.PI * Math.Pow(straal, 2);
            return oppervlakteCirkel;
        }

        public static double VolumeBalk(double lengte, double breedte, double hoogte)
        {
            double volumeBalk = lengte * breedte * hoogte;
            return volumeBalk;
        }

        public static double VolumeCilinder(double straal, double hoogte)
        {
            double volumeCilinder = Math.PI * Math.Pow(straal, 2) * hoogte;
            return volumeCilinder;
        }
    }
}
