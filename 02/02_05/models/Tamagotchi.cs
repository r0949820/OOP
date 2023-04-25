using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Tamagotchi
    {
        // Attributes
        private int _goedGevoel;
        private int _honger;
        private DateTime _laatsteMaaltijd;
        private string _naam;

        // Properties
        public int GoedGevoel
        {
            get { return _goedGevoel; }
            set
            {
                if (value < -10) _goedGevoel = -10;
                else if (value > 10) _goedGevoel = 10;
                else _goedGevoel = value;
            }
        }

        public int Honger
        {
            get { return _honger; }
            set
            {
                if (value < -5) _honger = -5;
                else if (value > 20) _honger = 20;
                else _honger = value;
            }
        }

        public DateTime LaatsteMaaltijd
        {
            get { return _laatsteMaaltijd; }
            set { _laatsteMaaltijd = value; }
        }

        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        // Constructors
        public Tamagotchi(string naam) : this(naam, 5, 5) { }

        public Tamagotchi(string naam, int eenHonger, int eenGevoel)
        {
            this.Naam = naam;
            this.Honger = eenHonger;
            this.GoedGevoel = eenGevoel;
            this.LaatsteMaaltijd = DateTime.Now;
        }

        // Methods
        public void Eten(int eenheden)
        {
            if (eenheden > 3)
            {
                this.Honger += 3;
            }
            else
            {
                this.Honger += eenheden;
            }

            this.LaatsteMaaltijd = DateTime.Now;
        }
        public void Liefkozen()
        {
            this.GoedGevoel++;
        }

        public void Straffen(int eenheden)
        {
            this.GoedGevoel -= eenheden;
        }

        public string Gevoel()
        {
            string output;
            DateTime nu;
            TimeSpan tijd;
            int seconden, hongerEenheden;

            nu = DateTime.Now;
            tijd = nu.Subtract(this.LaatsteMaaltijd);
            seconden = tijd.Hours * 3600 + tijd.Minutes * tijd.Seconds;
            hongerEenheden = seconden / 30;

            if (this.GoedGevoel > 0)
            {
                this.GoedGevoel--;
            }

            if (hongerEenheden > 0)
            {
                this.Honger -= hongerEenheden;
                this.LaatsteMaaltijd = nu;
            }

            output = $"Gevoel = {this.GoedGevoel} - Honger = {this.Honger}";

            return output;
        }
    }
}
