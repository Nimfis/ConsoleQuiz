using Microsoft.EntityFrameworkCore;
using Test_SAVOIR__VIVRE.Persistence.Database.Service;

namespace Test_SAVOIR__VIVRE
{
    internal static class Program
    {
        private static IAppDbContext AppDbContext;
        static void Main()
        {
            AppDbContext = new AppDbContext();
            var quiz = new Quiz(QuestionsData.Questions);
            quiz.StartQuiz();
        }
    }
}
