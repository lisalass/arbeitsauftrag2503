using Quiz.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbeitsauftrag_game
{
    class Program
    {
        static void Main(string[] args)

        {
            Game spiel = new Game();

            Question frage1 = new Question("Wie viele Bundesländer hat Deutschland?");
            frage1.AddAnswer(new Answer("18"));
            frage1.AddAnswer(new Answer("16", true));
            spiel.AddQuestion(frage1);

            Console.WriteLine(frage1.Text);

            Question frage2 = new Question("Wie viele Infizierte hat derzeit Deutschland?");
            frage2.AddAnswer(new Answer("35.000"));
            frage2.AddAnswer(new Answer("36.100"));
            frage2.AddAnswer(new Answer("35.700", true));
            spiel.AddQuestion(frage2);
           

            Console.WriteLine(frage2.Text);

            Question frage3 = new Question("Wie viele Schüler gehen in Österreich nicht in die Schule wegen der Corona-Krise?");
            frage3.AddAnswer(new Answer("1.450.000"));
            frage3.AddAnswer(new Answer("1.350.000"));
            frage3.AddAnswer(new Answer("1.380.000"));
            frage3.AddAnswer(new Answer("1.400.000", true));
            spiel.AddQuestion(frage3);

            Console.WriteLine(frage3.Text);

            while (spiel.Status == GameStatus.Active)
            {
                var frage = spiel.NextQuestion;
                var antworten = frage.Answers;


                for (int i = 0; i < antworten.Count; i++)
                {
                    Console.WriteLine("Antworten: {0}", antworten[i]);
                }

                Console.WriteLine("Bitte geben Sie eine Zahl ein: {Answers}", antworten);
                antworten[0].IsChecked = true; 

                spiel.ValidateCurrentQuestion();
            }

            Console.WriteLine(spiel.Status); 

        }
    }
}
