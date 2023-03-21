using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Punt
    {
        //Atributen
        private double _x;
        private double _y;
        

        //Properties
        public double X
        {
            get { return _x; }
            set { _x = value; }
        }
        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }
        public virtual string Omschrijving
        {
            get { return $"{this.GetType().Name}: coord=({X},{Y})"; }
        }

        //Constructor
        public Punt(double x, double y)
        {
            this.X= x;
            this.Y= y;
        }
        public Punt()
        {}

        //Methoden
        public virtual string ToonGegevens()
        {
            return $"{Omschrijving}";
        }
    }
}
