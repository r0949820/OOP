using models;
using System;
using System.Collections.Generic;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("0. Donut");
            Console.WriteLine("1. Koffie");
            Console.WriteLine();
            Console.Write("Geef een optie op: ");
            string keuze = Console.ReadLine().ToLower();

            if (keuze == "donut")
            {
                List<string> siroop = FileOperations.LeesOpties(FileOperations.BestandSiropen);
                List<string> topping = FileOperations.LeesOpties(FileOperations.BestandToppings);
                List<string> glazuur = FileOperations.LeesOpties(FileOperations.BestandGlazuren);
                List<string> vullingen = FileOperations.LeesOpties(FileOperations.BestandVullingen);

                Console.WriteLine();
                
                for (int i = 0; i < siroop.Count; i++)
                {
                    Console.WriteLine($"{i}. {siroop[i]}");
                }
                Console.WriteLine();
                Console.Write("Kies een siroop: ");
                int siroopKeuze = int.Parse(Console.ReadLine());

                Console.WriteLine();
                for (int i = 0; i < topping.Count; i++)
                {
                    Console.WriteLine($"{i}. {topping[i]}");
                }
                Console.WriteLine();
                Console.Write("Kies een topping: ");
                int toppingKeuze = int.Parse(Console.ReadLine());

                Console.WriteLine();
                
                for (int i = 0; i < glazuur.Count; i++)
                {
                    Console.WriteLine($"{i}. {glazuur[i]}");
                }
                Console.WriteLine();
                Console.Write("Kies een glazuur: ");
                int glazuurKeuze = int.Parse(Console.ReadLine());

                Console.WriteLine();
                
                for (int i = 0; i < vullingen.Count; i++)
                {
                    Console.WriteLine($"{i}. {vullingen[i]}");
                }
                Console.WriteLine();
                Console.Write("Kies een vulling: ");
                int vullingKeuze = int.Parse(Console.ReadLine());
                
                Donut donut = new Donut(siroop[siroopKeuze], topping[toppingKeuze], glazuur[glazuurKeuze], vullingen[vullingKeuze]);
                Console.WriteLine();
                Console.WriteLine("Bedankt voor uw bestelling!");
                Console.WriteLine();
                Console.WriteLine("Uw bestelling:");
                Console.WriteLine(donut.ToonOverzicht());
            }
            else if (keuze == "koffie")
            {
                List<string> siropen = FileOperations.LeesOpties(FileOperations.BestandSiropen);
                List<string> toppings = FileOperations.LeesOpties(FileOperations.BestandToppings);
                List<string> smaken = FileOperations.LeesOpties(FileOperations.BestandSmaken);

                Console.WriteLine();
                
                for (int i = 0; i < siropen.Count; i++)
                {
                    Console.WriteLine($"{i}. {siropen[i]}");
                }
                Console.WriteLine();
                Console.Write("Kies een siroop: ");
                int siroopKeuze = int.Parse(Console.ReadLine());

                Console.WriteLine();
                for (int i = 0; i < toppings.Count; i++)
                {
                    Console.WriteLine($"{i}. {toppings[i]}");
                }
                Console.WriteLine();
                Console.Write("Kies een topping: ");
                int toppingKeuze = int.Parse(Console.ReadLine());

                Console.WriteLine();
                for (int i = 0; i < smaken.Count; i++)
                {
                    Console.WriteLine($"{i}. {smaken[i]}");
                }
                Console.WriteLine();
                Console.Write("Kies een smaak: ");
                int smakenKeuze = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Wenst u slagroom: ");
                string slagroom = Console.ReadLine();
                bool metSlagroom = (slagroom.ToLower() == "ja");
                

                Koffie koffie = new Koffie(siropen[siroopKeuze], toppings[toppingKeuze], smaken[smakenKeuze], metSlagroom);
                Console.WriteLine();
                Console.WriteLine("Bedankt voor uw bestelling!");
                Console.WriteLine();
                Console.WriteLine("Uw bestelling:");
                Console.WriteLine(koffie.ToonOverzicht());
            }
            }
    }
}
