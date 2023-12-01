using Autofac;
using Test_SAVOIR__VIVRE.Persistence.Database.Service;

namespace Test_SAVOIR__VIVRE.Persistence
{
    public class PersistenceModule : Module 
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AppDbContext>().As<IAppDbContext>();
        }
    }
}
