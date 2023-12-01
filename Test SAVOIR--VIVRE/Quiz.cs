using Microsoft.EntityFrameworkCore;
using Test_SAVOIR__VIVRE.Persistence.Database.Entities;
using Test_SAVOIR__VIVRE.Persistence.Database.Service;

namespace Test_SAVOIR__VIVRE
{

    internal class Quiz
    {
        private IQueryable<Question> Questions => _appDbContext.Questions.AsNoTracking().AsQueryable();
        private IQueryable<Answer> Answers => _appDbContext.Answers.AsNoTracking().AsQueryable();
        public int Score { get; private set; }

        private readonly IAppDbContext _appDbContext;
        public Quiz(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task StartQuizAsync()
        {
            var questions = await GetRandomQuestionsAsync();

            if (questions is null)
            {
                throw new Exception("Tried to get random questions, but got null.");
            }

            var score = 0;
            foreach (var (question, answers) in questions)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                TextCenterer.PrintCenteredText(question.Content);
                Console.WriteLine();
                Console.ResetColor();

                for (int i = 1; i <= answers.Count; i++)
                {
                    var answer = $"{i}. {answers[i - 1].Content}";
                    TextCenterer.PrintCenteredText(answer);
                }

                Console.ForegroundColor = ConsoleColor.Blue;
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
                    TextCenterer.PrintCenteredText($"Błędna odpowiedź.");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    TextCenterer.PrintCenteredText($"Poprawna odpowiedź to: {correctAnswer.Content}");
                }

                Console.ResetColor();
                InputBlocker.WaitForEnter();
                Console.Clear();
            }

            Score = score;
            Console.ForegroundColor= ConsoleColor.Yellow;
            TextCenterer.PrintCenteredText($"Twój wynik: {Score}/{questions.Count}");
            Console.ResetColor();

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
                               join q in Questions on a.Question.Id equals q.Id
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

            var questionsIDs = await Questions
                .OrderBy(q => Guid.NewGuid())
                .Take(numberOfQuestions)
                .Select(q => q.Id)
                .ToListAsync();

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
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine();
                TextCenterer.PrintCenteredText("Podaj numer poprawnej odpowiedzi: ");
                Console.ForegroundColor = ConsoleColor.Yellow;

                parseResult = int.TryParse(Console.ReadLine(), out userAnswer);

                Console.ForegroundColor = ConsoleColor.Red;

                if (!parseResult || parseResult == userAnswer > answersNumber)
                {
                    TextCenterer.PrintCenteredText("Nieprawidłowa wartość");
                }
            } while (userAnswer < 1 || userAnswer > answersNumber);

            return userAnswer - 1;
        }
    }
}
