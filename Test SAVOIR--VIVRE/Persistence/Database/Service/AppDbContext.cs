using Microsoft.EntityFrameworkCore;
using Test_SAVOIR__VIVRE.Persistence.Database.Entities;

namespace Test_SAVOIR__VIVRE.Persistence.Database.Service
{
    public class AppDbContext : DbContext, IAppDbContext
    {
        public DbSet<Question> Questions { get; init; }
        public DbSet<Answer> Answers { get; init; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost, 1433;Database=QuizDb;User Id=sa;Password=P@$$w0rd;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
