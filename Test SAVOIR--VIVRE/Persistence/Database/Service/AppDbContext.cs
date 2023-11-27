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
            optionsBuilder.UseSqlServer("Server=localhost, 1433;Database=QuizDb;User Id=sa;Password=P@$$w0rd;Encrypt=False;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var questions = new List<Question>
            {
                new()
                {
                    Id = Guid.Parse("d9e1965b-799b-4e8c-a721-8fa3c1fb868c"),
                    Content = "Który z przykładów dotyczących pozdrawiania jest prawidłowy?",
                    Points = 1,
                },
                new()
                {
                    Id = Guid.Parse("8537c713-995c-4365-8146-dfd18b3283e8"),
                    Content = "Kto pierwszy mówi dzień dobry, osoba wchodzi do pomieszczenia czy osoby które się w pomieszczeniu znajdują?",
                    Points = 1,
                },
                new()
                {
                    Id = Guid.Parse("aa2a716c-a5d6-48a4-8c0e-6bbfe2ffe796"),
                    Content = "W których z wymienionych sytuacji pozdrawiamy osoby nieznajome?",
                    Points = 1,
                },
                new()
                {
                    Id = Guid.Parse("893968ac-c125-4c37-b59a-441de2bafdce"),
                    Content = "Czy prawdą jest jeśli chodzi o przedstawianie się, że?",
                    Points = 1,
                },
                new()
                {
                    Id = Guid.Parse("2253e484-e47b-4277-b550-79ff908959cc"),
                    Content = "Która z odpowiedzi jest prawidłowa? Kto komu podaje dłoń?",
                    Points = 1,
                },
                new()
                {
                    Id = Guid.Parse("1e63cba0-0597-4bdd-a84e-d889d0e89267"),
                    Content = "Czy będąc w grupie ściskając dłoń możemy ją uścisnąć tylko jednej osobie a resztę pominąć?",
                    Points = 1,
                },
                new()
                {
                    Id = Guid.Parse("97300d8f-9d5b-4275-b5f4-e7dca0434b34"),
                    Content = "Jaki powinien być uścisk dłoni?",
                    Points = 1,
                },
                new()
                {
                    Id = Guid.Parse("63baba33-48aa-4a33-9fc0-3bf16edf598c"),
                    Content = "Jak przedstawić sobie wzajemnie osoby – mężczyznę i kobietę??",
                    Points = 1,
                },
                new()
                {
                    Id = Guid.Parse("82efba24-cf19-41a5-89af-2265a060374d"),
                    Content = "Jak przedstawić sobie wzajemnie osoby – młodszą i starszą?",
                    Points = 1,
                },
                new()
                {
                    Id = Guid.Parse("d2de62f2-d12f-4e23-812f-b26fd485932a"),
                    Content = "Co robi się z pięknie ułożoną serwetką na stole, gdzie ją kładziemy?",
                    Points = 1,
                },
            };

            modelBuilder.Entity<Question>().HasData(questions);
            modelBuilder.Entity<Answer>().HasData(new List<Answer>
            {
                new()
                {
                    Id = Guid.Parse("cdb81142-168d-4440-a48e-3339ca7c49ff"),
                    Question = questions.First(q => q.Id == Guid.Parse("d9e1965b-799b-4e8c-a721-8fa3c1fb868c")),
                    Content = "młodszy pozdrawia starszego",
                    Correct = false,
                },
                new()
                {
                    Id = Guid.Parse("f25acb8b-abde-4afe-a29f-59311c9f1bf8"),
                    Question = questions.First(q => q.Id == Guid.Parse("d9e1965b-799b-4e8c-a721-8fa3c1fb868c")),
                    Content = "mężczyzna kobietę",
                    Correct = false,
                },
                new()
                {
                    Id = Guid.Parse("5c979120-ea9b-4f03-b3d4-f8fc26f4ea2e"),
                    Question = questions.First(q => q.Id == Guid.Parse("d9e1965b-799b-4e8c-a721-8fa3c1fb868c")),
                    Content = "podwładny wita przełożonego",
                    Correct = false,
                },
                new()
                {
                    Id = Guid.Parse("387926f3-4f9d-4809-b571-cebe54b9f6a1"),
                    Question = questions.First(q => q.Id == Guid.Parse("d9e1965b-799b-4e8c-a721-8fa3c1fb868c")),
                    Content = "zarówno odp a, b jaki i c są prawidłowe",
                    Correct = true,
                },
                new()
                {
                    Id = Guid.Parse("ab083765-fdf0-4027-8653-e4b33851ce16"),
                    Question = questions.First(q => q.Id == Guid.Parse("8537c713-995c-4365-8146-dfd18b3283e8")),
                    Content = "pierwsze mówią osoby, które się w pomieszczeniu znajdują",
                    Correct = true,
                },
                new()
                {
                    Id = Guid.Parse("bc7b394e-1739-4279-9a81-12a59941554c"),
                    Question = questions.First(q => q.Id == Guid.Parse("8537c713-995c-4365-8146-dfd18b3283e8")),
                    Content = "pierwsza mówi osoba która wchodzi do pomieszczenia, nawet wtedy gdy jest przełożonym",
                    Correct = false,
                },
                new()
                {
                    Id = Guid.Parse("babe025d-f5e5-4481-8ad1-24257c7b1966"),
                    Question = questions.First(q => q.Id == Guid.Parse("aa2a716c-a5d6-48a4-8c0e-6bbfe2ffe796")),
                    Content = "wchodzimy do restauracji i mówimy dzień dobry",
                    Correct = false,
                },
                new()
                {
                    Id = Guid.Parse("15a55009-1420-4c18-8849-96336a7eaa13"),
                    Question = questions.First(q => q.Id == Guid.Parse("aa2a716c-a5d6-48a4-8c0e-6bbfe2ffe796")),
                    Content = "wchodząc do windy mówimy dzień dobry",
                    Correct = false,
                },
                new()
                {
                    Id = Guid.Parse("5a45569d-bfa3-47b6-8282-03febf17c4cf"),
                    Question = questions.First(q => q.Id == Guid.Parse("aa2a716c-a5d6-48a4-8c0e-6bbfe2ffe796")),
                    Content = "pojawiając się w poczekalni u lekarza mówimy dzień dobry",
                    Correct = false,
                },
                new()
                {
                    Id = Guid.Parse("479fef7c-9f64-4902-bea0-aa8292b5779f"),
                    Question = questions.First(q => q.Id == Guid.Parse("aa2a716c-a5d6-48a4-8c0e-6bbfe2ffe796")),
                    Content = "w żadnej z tych sytuacji osób nieznajomych nie pozdrawiamy",
                    Correct = false,
                },
                 new()
                {
                    Id = Guid.Parse("9b90c8c3-b7b9-4e14-b478-e0f4c69e9080"),
                    Question = questions.First(q => q.Id == Guid.Parse("aa2a716c-a5d6-48a4-8c0e-6bbfe2ffe796")),
                    Content = "w każdej z tych sytuacji pozdrawiamy osoby nieznajome",
                    Correct = true,
                },
                new()
                {
                    Id = Guid.Parse("ece30e97-842a-4ec0-8f08-4f1f49f582d5"),
                    Question = questions.First(q => q.Id == Guid.Parse("893968ac-c125-4c37-b59a-441de2bafdce")),
                    Content = "starszy przedstawia się młodszemu",
                    Correct = false,
                },
                new()
                {
                    Id = Guid.Parse("7001c56e-093d-42db-bc3c-6ac985b85875"),
                    Question = questions.First(q => q.Id == Guid.Parse("893968ac-c125-4c37-b59a-441de2bafdce")),
                    Content = "kobieta przedstawia się mężczyźnie",
                    Correct = false,
                },
                new()
                {
                    Id = Guid.Parse("f100d61a-cef8-413f-851c-9f5e13872dea"),
                    Question = questions.First(q => q.Id == Guid.Parse("893968ac-c125-4c37-b59a-441de2bafdce")),
                    Content = "żadna z tych odpowiedzi nie jest prawidłowa",
                    Correct = true,
                },
                new()
                {
                    Id = Guid.Parse("23073c9d-a894-49d7-aede-e2e89b87d50a"),
                    Question = questions.First(q => q.Id == Guid.Parse("893968ac-c125-4c37-b59a-441de2bafdce")),
                    Content = "obydwie odpowiedzi są prawidłowe",
                    Correct = false,
                },
                new()
                {
                    Id = Guid.Parse("7e97ff82-1f6f-4b1b-947d-7f2421f6e880"),
                    Question = questions.First(q => q.Id == Guid.Parse("2253e484-e47b-4277-b550-79ff908959cc")),
                    Content = "starszy podaje dłoń młodszemu",
                    Correct = false,
                },
                new()
                {
                    Id = Guid.Parse("73c1e81a-4f0d-4112-83fb-150d8b0561b9"),
                    Question = questions.First(q => q.Id == Guid.Parse("2253e484-e47b-4277-b550-79ff908959cc")),
                    Content = "kobieta – mężczyźnie",
                    Correct = false,
                },
                new()
                {
                    Id = Guid.Parse("36eceb3e-aa38-4a00-80d0-df89c977af17"),
                    Question = questions.First(q => q.Id == Guid.Parse("2253e484-e47b-4277-b550-79ff908959cc")),
                    Content = "odpowiedzi a i b są prawidłowe",
                    Correct = true,
                },
                new()
                {
                    Id = Guid.Parse("4caf9d5c-d675-402b-a1db-1552a6df0220"),
                    Question = questions.First(q => q.Id == Guid.Parse("1e63cba0-0597-4bdd-a84e-d889d0e89267")),
                    Content = "w grupie należy powitać wszystkich tak samo",
                    Correct = true,
                },
                new()
                {
                    Id = Guid.Parse("9291a11d-d6fb-4dd6-99f6-17804215ca73"),
                    Question = questions.First(q => q.Id == Guid.Parse("1e63cba0-0597-4bdd-a84e-d889d0e89267")),
                    Content = "w grupie podają sobie rękę tylko ci którzy się znają",
                    Correct = false,
                },
                new()
                {
                    Id = Guid.Parse("dd890336-d2cc-4bcc-a9b5-02cdef3ea4d2"),
                    Question = questions.First(q => q.Id == Guid.Parse("1e63cba0-0597-4bdd-a84e-d889d0e89267")),
                    Content = "w grupie podają sobie rękę tylko mężczyźni",
                    Correct = false,
                },
                new()
                {
                    Id = Guid.Parse("36ffdd1a-c6c4-45b1-8b1f-10080d2a8cee"),
                    Question = questions.First(q => q.Id == Guid.Parse("97300d8f-9d5b-4275-b5f4-e7dca0434b34")),
                    Content = "powinien być pewny, ale nie za mocny, w żadnym razie również zbyt słaby",
                    Correct = true,
                },
                new()
                {
                    Id = Guid.Parse("be259869-f366-4105-9a47-8ad32fa8e872"),
                    Question = questions.First(q => q.Id == Guid.Parse("97300d8f-9d5b-4275-b5f4-e7dca0434b34")),
                    Content = "powinien być bardzo silny",
                    Correct = false,
                },
                new()
                {
                    Id = Guid.Parse("00976f85-b864-4772-b1d5-49ea9e56be40"),
                    Question = questions.First(q => q.Id == Guid.Parse("97300d8f-9d5b-4275-b5f4-e7dca0434b34")),
                    Content = "powinien być bardzo słabiutki",
                    Correct = false,
                },
                new()
                {
                    Id = Guid.Parse("7a5f6878-08dc-4e40-b335-29df7d98334b"),
                    Question = questions.First(q => q.Id == Guid.Parse("63baba33-48aa-4a33-9fc0-3bf16edf598c")),
                    Content = "najpierw wymieniamy imię i nazwisko mężczyzny",
                    Correct = true,
                },
                new()
                {
                    Id = Guid.Parse("9cad2531-e2e3-4582-bd56-5d3a5c0ed04d"),
                    Question = questions.First(q => q.Id == Guid.Parse("63baba33-48aa-4a33-9fc0-3bf16edf598c")),
                    Content = "najpierw wymieniamy imię i nazwisko kobiety",
                    Correct = false,
                },
                new()
                {
                    Id = Guid.Parse("70dbae90-644f-4582-bd78-70b04fdf90c7"),
                    Question = questions.First(q => q.Id == Guid.Parse("63baba33-48aa-4a33-9fc0-3bf16edf598c")),
                    Content = "kolejność nie ma znaczenia",
                    Correct = false,
                },
                new()
                {
                    Id = Guid.Parse("99b58dae-9c18-40f4-9514-db7e5ba02435"),
                    Question = questions.First(q => q.Id == Guid.Parse("82efba24-cf19-41a5-89af-2265a060374d")),
                    Content = "starsza osoba jest przedstawiana młodszej, a następnie młodsza starszej",
                    Correct = false,
                },
                new()
                {
                    Id = Guid.Parse("e8832762-68c6-4420-9688-0f63152332f5"),
                    Question = questions.First(q => q.Id == Guid.Parse("82efba24-cf19-41a5-89af-2265a060374d")),
                    Content = "młodsza osoba jest przedstawiana starszej, a następnie starsza młodszej",
                    Correct = true,
                },
                new()
                {
                    Id = Guid.Parse("6514ec29-72e3-4ec2-b46e-1d65630de093"),
                    Question = questions.First(q => q.Id == Guid.Parse("82efba24-cf19-41a5-89af-2265a060374d")),
                    Content = "w relacji młodszy – starszy – kolejność jest bez różnicy",
                    Correct = false,
                },
                new()
                {
                    Id = Guid.Parse("c69f9bcb-5bc8-4802-8706-de4bea1820af"),
                    Question = questions.First(q => q.Id == Guid.Parse("d2de62f2-d12f-4e23-812f-b26fd485932a")),
                    Content = "za kołnierzyk",
                    Correct = false,
                },
                new()
                {
                    Id = Guid.Parse("6b6ceeb9-cad9-44b6-abe4-1ae298ec627f"),
                    Question = questions.First(q => q.Id == Guid.Parse("d2de62f2-d12f-4e23-812f-b26fd485932a")),
                    Content = "odkładamy na bok",
                    Correct = false,
                },
                new()
                {
                    Id = Guid.Parse("31590c8b-560f-4552-ad3c-b65d683b34ce"),
                    Question = questions.First(q => q.Id == Guid.Parse("d2de62f2-d12f-4e23-812f-b26fd485932a")),
                    Content = "kładziemy ją na kolanach",
                    Correct = true,
                },
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
