using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Test_SAVOIR__VIVRE
{
    internal class Quiz
    {
        public List<Question> Questions { get; init; }
        public string Text { get; init; }
        public bool IsCorrect { get; init; }

        public Quiz() => Questions = new List<Question>();

        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }

        public void StartQuiz()
        {
            Answer CorrectAnswer = new Answer(Text, true);
            Answer WrongAnswer = new Answer(Text, false);
            int score = 0;

            foreach (var question in Questions)
            {
                Console.ForegroundColor = Question.TextColor;

                Console.WriteLine(question.Text);
                Console.WriteLine();
              
                Console.ForegroundColor = Answer.TextColor;

                for (int i = 0; i < question.Answers.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {question.Answers[i].Text}");
                }

                Console.ForegroundColor = ConsoleColor.White;

                int userAnswer = GetUserAnswer(question);
                

                if (question.Answers[userAnswer - 1].IsCorrect)
                {
                    Console.ForegroundColor = CorrectAnswer.FinalAnswerColor;
                    Console.WriteLine("Poprawna odpowiedź!\n");
                    score++;
                }
                else
                {
                    Console.ForegroundColor = WrongAnswer.FinalAnswerColor;
                    Console.WriteLine($"Błędna odpowiedź. Poprawna odpowiedź to: {GetCorrectAnswerIndex(question) + 1}. {question.Answers[GetCorrectAnswerIndex(question)].Text}\n");
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Naciśnij <ENTER>, aby przejść dalej.");

                while (Console.ReadKey().Key != ConsoleKey.Enter) { }

                Console.Clear();
            }

            Console.WriteLine($"Twój wynik: {score}/{Questions.Count}");
        }

        private int GetUserAnswer(Question question)
        {
            int userAnswer = -1;
            bool parseResult;

            Answer WrongAnswer = new Answer(Text, false);

            do
            {
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine();
                Console.WriteLine("Podaj numer poprawnej odpowiedzi: ");
                parseResult = int.TryParse(Console.ReadLine(), out userAnswer);

                if (!parseResult || parseResult == userAnswer > question.Answers.Count)
                {
                    Console.ForegroundColor = WrongAnswer.FinalAnswerColor;
                    Console.WriteLine("Nieprawidłowa wartość");
                }
            } while (userAnswer < 1 || userAnswer > question.Answers.Count);

            return userAnswer;
        }

        private int GetCorrectAnswerIndex(Question question)
        {
            for (int i = 0; i < question.Answers.Count; i++)
            {
                if (question.Answers[i].IsCorrect)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}