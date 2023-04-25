using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Trein
    {
        // Attributen
        private bool _deurOpen;
        private int _passagiers;
        private int _snelheid;

        // Properties
        public bool DeurOpen
        {
            get { return _deurOpen; }
            set { _deurOpen = value; }
        }

        public int Passagiers
        {
            get { return _passagiers; }
            private set
            {
                if (value < 0) _passagiers = 0;
                else _passagiers = value;
            }
        }

        public int Snelheid
        {
            get { return _snelheid; }
            private set
            {
                if (value < 0) _snelheid = 0;
                else if (value > 120) _snelheid = 120;
                else _snelheid = value;
            }
        }

        // Constructors
        public Trein()
        {
            this.DeurOpen = true;
            this.Passagiers = 0;
        }

        // Methodes
        public bool Afstappen(int aantalAfstappen)
        {
            if (this.DeurOpen)
            {
                this.Passagiers -= aantalAfstappen;
                return true;
            }
            return false;

        }

        public bool Opstappen(int aantalOpstappen)
        {
            if (this.DeurOpen)
            {
                this.Passagiers += aantalOpstappen;
                return true;
            }
            return false;

        }

        public void SluitDeur()
        {
            this.DeurOpen = false;
        }

        public void WijzigSnelheid(int wijzigingSnelheid)
        {
            this.Snelheid += wijzigingSnelheid;
        }

        public void Stoppen()
        {
            this.WijzigSnelheid(this.Snelheid * -1);
            this.DeurOpen = true;
        }

        public bool Versnellen(int versnelling)
        {
            if (!this.DeurOpen)
            {
                this.WijzigSnelheid(versnelling);
                return true;
            }

            return false;
        }

        public void Remmen(int vertraging)
        {
            this.WijzigSnelheid(vertraging * -1);
        }

        public string StandVanZaken()
        {
            string output = $"Snelheid: {this.Snelheid}"
                + Environment.NewLine
                + $"Passagiers: {this.Passagiers}"
                + Environment.NewLine;

            if (this.DeurOpen == true)
                output += "Deuren: Open";
            else
                output += "Deuren: Gesloten";

            return output;
        }
    }
}
