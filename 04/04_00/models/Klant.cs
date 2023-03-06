using System;
using System.Collections.Generic;
using System.Text;

namespace models
{
    public class Klant : Persoon
    {
        //Atributen
        private string _klantenCode;

        //Properties
        private string KlantenCode
        {
            get { return _klantenCode; }
            set { _klantenCode = value; }
        }


        //Constructor
        public Klant(string voornaam, string achternaam) : base(voornaam, achternaam)
        {
            MaakRandomKlantenCode();
        }

        //Methodes
        private void MaakRandomKlantenCode()
        {
            string toegelatenKarakters = "ABCDEFGHIJKLNMOPQRSTUVWXYZ0123456789";

            char[] klantencode = new char[16];

            Random r = new Random();

            for (int i = 0; i < klantencode.Length; i++)
            {
                klantencode[i] = toegelatenKarakters[r.Next(toegelatenKarakters.Length)];
            }

            KlantenCode = new string(klantencode);
        }

        public override string ToonGegevens()
        {
            return base.ToonGegevens() + $" mijn klantencode : {KlantenCode}";
        }
    }
}
