using Microsoft.EntityFrameworkCore;

namespace Test_SAVOIR__VIVRE.Persistence.Database.Service
{
    public interface IAppDbContext
    {
        DbSet<Question> Questions { get; init; }
        DbSet<Answer> Answers { get; init; }
    }
}
