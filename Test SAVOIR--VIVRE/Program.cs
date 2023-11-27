using Microsoft.EntityFrameworkCore;
using Test_SAVOIR__VIVRE.Persistence.Database.Service;

namespace Test_SAVOIR__VIVRE
{
    internal static class Program
    {
        private readonly static DbContextOptions<AppDbContext> Options = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlServer("Server=localhost, 1433;Database=QuizDb;User Id=sa;Password=P@$$w0rd;")
            .Options;

        private readonly static IAppDbContext AppDbContext = new AppDbContext(Options);
        static void Main()
        {
            var quiz = new Quiz(QuestionsData.Questions);
            quiz.StartQuiz();
        }
    }
}
