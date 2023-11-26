using Microsoft.EntityFrameworkCore;
using Test_SAVOIR__VIVRE.Persistence.Database.Entities;

namespace Test_SAVOIR__VIVRE.Persistence.Database.Service
{
    public class AppDbContext : DbContext, IAppDbContext
    {
        public DbSet<Question>  Questions { get; init; }
        public DbSet<Answer> Answers { get; init; }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {
            
        }
    }
}
