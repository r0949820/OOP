using System;
using System.Collections.Generic;
using models;
using DAL;

namespace console

{
    class Program
    {
        static void Main(string[] args)
        {
            //Variabelen
            string input, message = "Wat wil je doen?";
            int keuze;

            Console.WriteLine(message);
            Console.WriteLine(new string('-', message.Length));
            Console.WriteLine("" +
                "1. Resultaat afdrukken\n" +
                "2. Afsluiten\n");

            do
            {
                Console.Write("Maak een keuze: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out keuze) || keuze < 1 || keuze > 2);

            if (keuze == 1)
            {
                List<ResultaatStudent> studenten = DAL.FileOperations.LeesStudenten();

                foreach (ResultaatStudent student in studenten)
                {
                    Console.WriteLine(student.ToString());
                }
            }
        }
    }
}
