using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Test_SAVOIR__VIVRE.Model;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;

namespace Test_SAVOIR__VIVRE
{

    internal class Quiz
    {
        public List<Question> Questions { get; init; }
        public string Text { get; init; }
        public bool IsCorrect { get; init; }
        public object Score { get; private set; }
        public string UserName { get; private set; }

        public Quiz(List<Question> questions)
        {
            Questions = questions;
        }

        public void StartQuiz()
        {
            var correctAnswer = new Answer(Text, true);
            var wrongAnswer = new Answer(Text, false);

            int score = 0;

            foreach (var question in Questions)
            {
                Console.ForegroundColor = Question.TextColor;
               
                TextCenterer.PrintCenteredText(question.Text);
                Console.WriteLine();
              
                Console.ForegroundColor = Answer.TextColor;

                for (int i = 0; i < question.Answers.Count; i++)
                {
                    TextCenterer.PrintCenteredText($"{i + 1}. {question.Answers[i].Text}");
                }

                Console.ForegroundColor = ConsoleColor.White;

                int userAnswer = GetUserAnswer(question);
                

                if (question.Answers[userAnswer - 1].IsCorrect)
                {
                    Console.ForegroundColor = correctAnswer.FinalAnswerColor;
                    TextCenterer.PrintCenteredText("Poprawna odpowiedź!\n");
                    score++;
                }
                else
                {
                    Console.ForegroundColor = wrongAnswer.FinalAnswerColor;
                    TextCenterer.PrintCenteredText($"Błędna odpowiedź. Poprawna odpowiedź to: {GetCorrectAnswerIndex(question) + 1}. {question.Answers[GetCorrectAnswerIndex(question)].Text}\n");
                }

                Console.ForegroundColor = ConsoleColor.White;
                TextCenterer.PrintCenteredText("Naciśnij <ENTER>, aby przejść dalej.");

                InputBlocker.BlockUserInput();

                Console.Clear();
            }

            Score = score;

            TextCenterer.PrintCenteredText($"Twój wynik: {Score}/{Questions.Count}");

            User user = new User();

            string userName = user.ValidUserName();
            
            Result.SaveResult(userName, (int)Score, Questions.Count);
            Result.DisplayResults();
        }

        private int GetUserAnswer(Question question)
        {
            int userAnswer = -1;
            bool parseResult;

            Answer WrongAnswer = new Answer(Text, false);

            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine();
                TextCenterer.PrintCenteredText("Podaj numer poprawnej odpowiedzi: ");

                Console.ResetColor();

                parseResult = int.TryParse(Console.ReadLine(), out userAnswer);

                if (!parseResult || parseResult == userAnswer > question.Answers.Count)
                {
                    Console.ForegroundColor = WrongAnswer.FinalAnswerColor;
                    TextCenterer.PrintCenteredText("Nieprawidłowa wartość");
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