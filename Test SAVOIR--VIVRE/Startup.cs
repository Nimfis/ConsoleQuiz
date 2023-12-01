using Test_SAVOIR__VIVRE.Persistence.Database.Service;

namespace Test_SAVOIR__VIVRE
{
    public class Startup
    {
        private readonly IAppDbContext appDbContext;

        public Startup(IAppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task RunAsync()
        {
            var quiz = new Quiz(appDbContext);
            await quiz.StartQuizAsync();
        }
    }
}
