using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Test_SAVOIR__VIVRE
{
    internal class Quiz
    {
        public List<Question> Questions { get; set; }

        public Quiz()
        {
            Questions = new List<Question>();
        }

        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }

        public void StartQuiz()
        {
            int score = 0;

            foreach (var question in Questions)
            {
                Console.WriteLine(question.Text);

                for (int i = 0; i < question.Options.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {question.Options[i].Text}");
                }

                int userAnswer = GetUserAnswer();

                if (question.Options[userAnswer - 1].IsCorrect)
                {
                    Console.WriteLine("Poprawna odpowiedź!\n");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Błędna odpowiedź. Poprawna odpowiedź to: {GetCorrectAnswerIndex(question) + 1}. {question.Options[GetCorrectAnswerIndex(question)].Text}\n");
                }
            }

            Console.WriteLine($"Twój wynik: {score}/{Questions.Count}");
        }

        private int GetUserAnswer()
        {
            int userAnswer = -1;
            do
            {
                Console.Write("Podaj numer poprawnej odpowiedzi: ");
            } while (!int.TryParse(Console.ReadLine(), out userAnswer) || userAnswer < 1 || userAnswer > Questions[Questions.Count - 1].Options.Count);

            return userAnswer;
        }

        private int GetCorrectAnswerIndex(Question question)
        {
            for (int i = 0; i < question.Options.Count; i++)
            {
                if (question.Options[i].IsCorrect)
                {
                    return i;
                }
            }
            return -1;
        }
    }

}