using Autofac;
using Test_SAVOIR__VIVRE.Persistence.Database.Service;

namespace Test_SAVOIR__VIVRE
{
    internal static class Program
    {
        static async Task Main()
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<Startup>().AsSelf();
            containerBuilder.RegisterAssemblyModules(typeof(Program).Assembly);
            var container = containerBuilder.Build();
            await using var scope = container.BeginLifetimeScope();
            var app = container.Resolve<Startup>();
            await app.RunAsync();
        }
    }
}
