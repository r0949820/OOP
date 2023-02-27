using System;
using System.Collections.Generic;
using models;
namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variabelen
            int optie;
            List<string> studenten;
            List<int> scores;

            optie = VraagOptieOp();

            studenten = FileOperations.StudentenLezen();
            scores = FileOperations.ScoresLezen();

            switch (optie)
            {
                case 0:
                    DrukStudentenAf(studenten);
                    break;
                case 1:
                    DrukScoresAf(scores);
                    break;
                case 2:
                    DrukStudentenMetScoresAf(studenten, scores);
                    break;
            }
        }

        private static void DrukStudentenAf(List<string> studenten)
        {
            string uitvoer = "";
            foreach (string student in studenten)
            {
                uitvoer += $"{student}\n";
            }
            Console.WriteLine(uitvoer);
        }

        private static void DrukScoresAf(List<int> scores)
        {
            string uitvoer = "";
            foreach (int score in scores)
            {
                uitvoer += $"{score}\n";
            }
            Console.WriteLine(uitvoer);
        }

        private static void DrukStudentenMetScoresAf(List<string> studenten, List<int> scores)
        {
            string uitvoer = "";
            
            for (int i = 0; i < studenten.Count; i++)
            {
                uitvoer += $"{studenten[i]} ({scores[i]})\n";
            }

            Console.WriteLine(uitvoer);
        }

        private static int VraagOptieOp()
        {
            int optie;
            string invoer;
            do
            {
                Console.WriteLine("0. Studenten\r\n1. Scores\r\n2. Studenten met scores");
                invoer= Console.ReadLine();
            } while (!int.TryParse(invoer, out optie) || optie < 0 || optie > 2);

            return optie;
        }
    }
}
