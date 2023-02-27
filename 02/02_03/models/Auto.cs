using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace models
{
    public class Auto
    {
        //Atributen
        private double _brandstof;
        private int _kilometerstand;
        private int _kilometerstandOnderhoud;
        

        //Properties
        public double Brandstof
        {
            get { return _brandstof; }
            set
            {
                if (value < 0)
                {
                    _brandstof = 0;
                }
                else if (value > 60)
                {
                    _brandstof = 60;
                }
                else
                {
                    _brandstof = value;
                }
            }
        }
        public int Kilometerstand
        {
            get { return _kilometerstand;}
            set
            {
                if (value < 0)
                {
                    _kilometerstand = 0;
                }
                else
                {
                    _kilometerstand = value;
                }
            }
        }
        public int KilometerstandOnderhoud
        {
            get { return _kilometerstandOnderhoud; }
            set
            {
                if (value < 0)
                {
                    _kilometerstandOnderhoud = 0;
                }
                else
                {
                    _kilometerstandOnderhoud= value;
                }
            }
        }

        //Constructor
        public Auto()
        {
            Brandstof= 0;
            Kilometerstand = 0;
            KilometerstandOnderhoud = 0;
        }

        //Methodes
        public void KeuzeMenu(int keuze)
        {
            
            if (keuze == 0)
            {
                ToonStatus();
            }
            else if (keuze == 1)
            { 
                Kilometerstand += 25;
                Brandstof -= 1.25;
                ToonStatus();
            }
            else if (keuze == 2)
            {
                Kilometerstand += 100;
                Brandstof -= 5;
                ToonStatus();
            }
            else if (keuze == 3)
            {
                Kilometerstand+= 1000;
                Brandstof-= 50;
                ToonStatus();
            }
            else if (keuze == 4)
            {
                Console.Write("Geef hoeveelheid brandstof: ");
                double brandstof = double.Parse(Console.ReadLine());
                Brandstof += brandstof;
                ToonStatus();
            }
            else if (keuze == 5)
            {
                Kilometerstand = 0;
                ToonStatus();
            }
        }
        public double VoegBrandstofToe (double brandstof)
        {
            
            return Brandstof;
        }

        public void ToonStatus()
        {
            if (Brandstof > 10 && (Kilometerstand - KilometerstandOnderhoud < 25000))
            {
                Console.WriteLine("\n" +
                    "Status\n" +
                    "------\n" +
                    "De auto is volledig in orde!");
            }
            else if (Brandstof < 10 && (Kilometerstand - KilometerstandOnderhoud < 25000))
            {
                Console.WriteLine("\n" +
                    "Status\n" +
                    "------\n" +
                    "Voeg brandstof toe aub!");
            }
            else if (Brandstof > 10 && (Kilometerstand - KilometerstandOnderhoud > 25000))
            {
                Console.WriteLine("\n" +
                    "Status\n" +
                    "------\n" +
                    "Er is dringend onderhoud nodig!");
            }
            else if (Brandstof < 10 && (Kilometerstand - KilometerstandOnderhoud > 25000))
            {
                Console.WriteLine("\n" + "Status\n" +
                    "------\n" +
                    "Voeg brandstof toe aub!\n" +
                    "Er is dringend onderhoud nodig!");
            }
        }
	}
    
}
