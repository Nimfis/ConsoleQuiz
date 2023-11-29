using Microsoft.EntityFrameworkCore;
using Test_SAVOIR__VIVRE.Persistence.Database.Entities;
using System.Linq;

namespace Test_SAVOIR__VIVRE
{

    internal class Quiz
    {
        public IQueryable<Question> Questions { get; init; }
        public IQueryable<Answer> Answers { get; init; }
        public bool IsCorrect { get; init; }
        public object Score { get; private set; }
        public string UserName { get; private set; }

        public Quiz(IQueryable<Question> questions, IQueryable<Answer> answers)
        {
            Questions = questions;
        }

        public async void StartQuizAsync()
        {
            var questions = await GetRandomQuestionsAsync();

            if (questions is null)
            {
                throw new Exception("Tried to get random questions, but got null.");
            }

            var score = 0;
            foreach (var (question, answers) in questions)
            {
                TextCenterer.PrintCenteredText(question.Content);

                for (int i = 1; i <= answers.Count; i++)
                {
                    var answer = $"{i}. {answers[i - 1].Content}";
                    TextCenterer.PrintCenteredText(answer);
                }

                var userAnswerIndex = GetUserAnswerIndex(answers.Count);
                var userAnswer = answers[userAnswerIndex];

                if (userAnswer.Correct)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    TextCenterer.PrintCenteredText("Poprawna odpowiedź!");
                    score += question.Points;
                }            
                else 
                {
                    var correctAnswer = answers.First(a => a.Correct);
                    Console.ForegroundColor = ConsoleColor.Red;
                    TextCenterer.PrintCenteredText($"Błędna odpowiedź.\n Poprawna odpowiedź to {correctAnswer.Content}");
                }

                Console.ResetColor();
                InputBlocker.WaitForEnter();
                Console.Clear();
            }

            Score = score;

            TextCenterer.PrintCenteredText($"Twój wynik: {Score}/{questions.Count}");

            User user = new User();

            string userName = user.ValidUserName();

            Result.SaveResult(userName, (int)Score, questions.Count);
            Result.DisplayResults();
        }
        private async Task<(Question question, List<Answer> answers)?> GetQuestionWithAnswersAsync(Guid id)
        {
            var questionQuery = from questions in Questions
                                where questions.Id == id
                                select questions;

            var question = questionQuery.FirstOrDefault();
            //var question1 = Questions.FirstOrDefault(question => question.Id == id);

            if (question is null)
            {
                Console.WriteLine($"Question with ID {id} not found.");
                return null;
            }

            var answersQuery = from a in Answers
                               join q in Questions on a.Id equals q.Id
                               where a.Question.Id == id
                               select a;

            var answers = await answersQuery.Include(a => a.Question).ToListAsync();

            //var answers1 = await Answers
            //    .Include(a => a.Question)
            //    .Where(a => a.Question.Id == id)
            //    .ToListAsync();

            if (!answers.Any())
            {
                Console.WriteLine($"Answer with QuestionID {id} not found.");
                return null;
            }

            return (question, answers);
        }

        private async Task<Dictionary<Question, List<Answer>>?> GetRandomQuestionsAsync(int numberOfQuestions = 10)
        {
            var randomQuestions = new Dictionary<Question, List<Answer>>();

            var questionsIDs = Questions
                .OrderBy(q => Guid.NewGuid())
                .Take(numberOfQuestions)
                .Select(q => q.Id);

            foreach (var questionID in questionsIDs)
            {
                (Question question, List<Answer> answers)? questionsWithAnswers = await GetQuestionWithAnswersAsync(questionID);
                if (questionsWithAnswers is null)
                {
                    Console.WriteLine($"Couldn't found question with answers for that ID.");
                    return null;
                }
                randomQuestions.Add(questionsWithAnswers.Value.question, questionsWithAnswers.Value.answers);
            }

            return randomQuestions;
        }

        private int GetUserAnswerIndex(int answersNumber)
        {
            int userAnswer = -1;
            bool parseResult;

            do
            {
                Console.WriteLine();
                TextCenterer.PrintCenteredText("podaj numer poprawnej odpowiedzi: ");

                parseResult = int.TryParse(Console.ReadLine(), out userAnswer);

                if (!parseResult || parseResult == userAnswer > answersNumber)
                {
                    TextCenterer.PrintCenteredText("nieprawidłowa wartość");
                }
            } while (userAnswer < 1 || userAnswer > answersNumber);

            return userAnswer - 1;
        }
    }
}
