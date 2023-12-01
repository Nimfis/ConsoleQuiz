using Microsoft.EntityFrameworkCore;
using Test_SAVOIR__VIVRE.Persistence.Database.Service;

namespace Test_SAVOIR__VIVRE
{
    internal static class Program
    {
        private static IAppDbContext AppDbContext;
        static async Task Main()
        {
            AppDbContext = new AppDbContext();
            var questions = AppDbContext.Questions.AsNoTracking().AsQueryable();
            var answers = AppDbContext.Answers.AsNoTracking().AsQueryable();
            var quiz = new Quiz(questions, answers);
            await quiz.StartQuizAsync();
        }
    }
}
