using System;
using models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variabelen
            string invoer;
            int keuzeAuto, keuzeActie, aantalKilometer;

            //Objecten
            Audi audi = new Audi("1-lvn-568", 25000, 7500, 25);
            Volkswagen volkswagen = new Volkswagen("1-sej-454", 100000, 5500, 10);
            BMW bmw = new BMW("1-hbj-298", 500, 12500, 44);

            Auto auto = null;

            Console.WriteLine($"Auto's\r\n{new string('*', 6)}\r\n0. Stoppen\r\n1. Audi (1-lvn-568)\r\n2. Volkswagen (1-sej-454)\r\n3. BMW (1-hbj-298)");

            do
            {
                Console.Write("Geef een auto: ");
                invoer = Console.ReadLine();
            } while (!int.TryParse(invoer, out keuzeAuto) || keuzeAuto < 0 || keuzeAuto > 3);


            while (keuzeAuto != 0)
            {
                //Stap 3: Herhalende taken
                switch (keuzeAuto)
                {
                    case 1:
                        auto = audi; 
                        break;
                    case 2:
                        auto = volkswagen;
                        break;
                    case 3:
                        auto = bmw;
                        break;
                }

                Console.WriteLine($"\nActies\n" +
                    $"******\n" +
                    $"0. Testrit maken\n" +
                    $"1. Details tonen");

                do
                {
                    Console.Write("Kies een actie: ");
                    invoer = Console.ReadLine();
                } while (!int.TryParse(invoer, out keuzeActie) || keuzeActie < 0 || keuzeActie > 1);

                switch (keuzeActie)
                {
                    case 0:
                        do
                        {
                            Console.Write("Geef aantal kilometer: ");
                            invoer = Console.ReadLine();
                        } while (!int.TryParse(invoer, out aantalKilometer) || aantalKilometer < 0);
                        auto.Rijden(aantalKilometer);

                        break;
                    case 1:
                        Console.WriteLine(auto.ToString());
                        break;
                }


                Console.WriteLine($"\nAuto's\r\n{new string('*', 6)}\r\n0. Stoppen\r\n1. Audi (1-lvn-568)\r\n2. Volkswagen (1-sej-454)\r\n3. BMW (1-hbj-298)");

                do
                {
                    Console.Write("Geef een auto: ");
                    invoer = Console.ReadLine();
                } while (!int.TryParse(invoer, out keuzeAuto) || keuzeAuto < 0 || keuzeAuto > 3);
            }
        }
    }
}
