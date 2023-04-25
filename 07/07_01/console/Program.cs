using System;
using models;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantieer een nieuw Plc object met de juiste lampen en verwarming
            Plc plc = new Plc(new Licht(), new Licht(), new Verwarming());

            // Variabele om te onthouden welk menu geselecteerd was
            int selectedMenu = -1;

            while (selectedMenu != 3)
            {
                // Laat het hoofdmenu zien
                Console.WriteLine("0. Keukenlicht");
                Console.WriteLine("1. Woonkamer");
                Console.WriteLine("2. Verwarming");
                Console.WriteLine("3. Afsluiten");
                Console.Write("Selecteer een optie: ");

                // Lees het ingevoerde nummer in en probeer het te converteren naar een int
                int.TryParse(Console.ReadLine(), out selectedMenu);

                // Controleer of het nummer een geldige optie is
                if (selectedMenu >= 0 && selectedMenu <= 3)
                {
                    switch (selectedMenu)
                    {
                        case 0:
                            HandleLichtMenu(plc.KeukenLicht);
                            break;
                        case 1:
                            HandleLichtMenu(plc.WoonkamerLicht);
                            break;
                        case 2:
                            HandleVerwarmingMenu(plc.Verwarming);
                            break;
                        default:
                            // Gebruiker heeft gekozen om de applicatie af te sluiten
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ongeldige optie, probeer opnieuw.");
                }
            }

            Console.WriteLine("Applicatie wordt afgesloten...");
        }

        // Behandelt de opties voor een Licht object
        static void HandleLichtMenu(Licht licht)
        {
            int selectedOption = -1;

            while (selectedOption != 0 && selectedOption != 1)
            {
                Console.WriteLine("0. Aan");
                Console.WriteLine("1. Uit");
                Console.Write("Selecteer een optie: ");
                int.TryParse(Console.ReadLine(), out selectedOption);

                if (selectedOption == 0)
                {
                    licht.AanUit = true;
                    Console.WriteLine("Licht is nu AAN.");
                }
                else if (selectedOption == 1)
                {
                    licht.AanUit = false;
                    Console.WriteLine("Licht is nu UIT.");
                }
                else
                {
                    Console.WriteLine("Ongeldige optie, probeer opnieuw.");
                }
            }
        }
        private static void HandleVerwarmingMenu(Verwarming verwarming)
        {
            int optie;
            do
            {
                Console.WriteLine("0. Aan");
                Console.WriteLine("1. Uit");
                Console.WriteLine("2. Temperatuur aanpassen");
                Console.Write("Kies een optie: ");
                if (int.TryParse(Console.ReadLine(), out optie))
                {
                    switch (optie)
                    {
                        case 0:
                            verwarming.AanUit = true;
                            Console.WriteLine("Verwarming is nu aan.");
                            break;
                        case 1:
                            verwarming.AanUit = false;
                            Console.WriteLine("Verwarming is nu uit.");
                            break;
                        case 2:
                            Console.Write("Geef nieuwe temperatuur in: ");
                            if (double.TryParse(Console.ReadLine(), out double temperatuur))
                            {
                                verwarming.Graden = temperatuur;
                                Console.WriteLine($"Verwarming is nu ingesteld op {temperatuur} graden.");
                            }
                            else
                            {
                                Console.WriteLine("Ongeldige invoer voor temperatuur.");
                            }
                            break;
                        default:
                            Console.WriteLine("Ongeldige optie.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ongeldige optie.");
                }
            } while (optie < 0 || optie > 2);
        }
    }
    }

