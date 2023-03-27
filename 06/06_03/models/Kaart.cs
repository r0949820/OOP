namespace models
{
    public class Kaart
    {
        // attributen
        private int _waarde;
        private string _soort;
        private string _kleur;

        // properties
        public int Waarde
        {
            get { return _waarde; }
            set { _waarde = value; }
        }
        public string Soort
        {
            get { return _soort; }
            set { _soort = value; }
        }
        public string Kleur
        {
            get { return _kleur; }
            set { _kleur = value; }
        }

        public Kaart(int waarde, string soort, string kleur)
        {
            Waarde = waarde;
            Soort = soort;
            Kleur = kleur;
        }

        // Overrides the Equals method to compare two Kaart objects for equality based on their Waarde, Soort, and Kleur properties.
        // Returns true if the properties of the two Kaart objects are equal, false otherwise.
        public override bool Equals(object obj)
        {
            if (obj is Kaart kaart)
            {
                return this.Waarde == kaart.Waarde &&
                    this.Soort == kaart.Soort &&
                    this.Kleur == kaart.Kleur;
            }
            else
            {
                return false;
            }
        }

        // Overrides the GetHashCode method to generate a unique hashcode for each Kaart object based on its Waarde, Soort, and Kleur properties.
        // Returns a unique integer hashcode that can be used to efficiently store and retrieve Kaart objects in hash-based data structures like dictionaries and hash tables.
        public override int GetHashCode()
        {
            return Waarde ^ Soort.GetHashCode() ^ Kleur.GetHashCode();
        }

        public override string ToString()
        {
            return $"{Waarde} {Soort} {Kleur}";
        }
    }
}
