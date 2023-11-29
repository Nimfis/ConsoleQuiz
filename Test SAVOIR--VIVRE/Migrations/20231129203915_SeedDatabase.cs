using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Test_SAVOIR__VIVRE.Migrations
{
    /// <inheritdoc />
    public partial class SeedDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Content", "Points" },
                values: new object[,]
                {
                    { new Guid("1e63cba0-0597-4bdd-a84e-d889d0e89267"), "Czy będąc w grupie ściskając dłoń możemy ją uścisnąć tylko jednej osobie a resztę pominąć?", 1 },
                    { new Guid("2253e484-e47b-4277-b550-79ff908959cc"), "Która z odpowiedzi jest prawidłowa? Kto komu podaje dłoń?", 1 },
                    { new Guid("63baba33-48aa-4a33-9fc0-3bf16edf598c"), "Jak przedstawić sobie wzajemnie osoby – mężczyznę i kobietę??", 1 },
                    { new Guid("82efba24-cf19-41a5-89af-2265a060374d"), "Jak przedstawić sobie wzajemnie osoby – młodszą i starszą?", 1 },
                    { new Guid("8537c713-995c-4365-8146-dfd18b3283e8"), "Kto pierwszy mówi dzień dobry, osoba wchodzi do pomieszczenia czy osoby które się w pomieszczeniu znajdują?", 1 },
                    { new Guid("893968ac-c125-4c37-b59a-441de2bafdce"), "Czy prawdą jest jeśli chodzi o przedstawianie się, że?", 1 },
                    { new Guid("97300d8f-9d5b-4275-b5f4-e7dca0434b34"), "Jaki powinien być uścisk dłoni?", 1 },
                    { new Guid("aa2a716c-a5d6-48a4-8c0e-6bbfe2ffe796"), "W których z wymienionych sytuacji pozdrawiamy osoby nieznajome?", 1 },
                    { new Guid("d2de62f2-d12f-4e23-812f-b26fd485932a"), "Co robi się z pięknie ułożoną serwetką na stole, gdzie ją kładziemy?", 1 },
                    { new Guid("d9e1965b-799b-4e8c-a721-8fa3c1fb868c"), "Który z przykładów dotyczących pozdrawiania jest prawidłowy?", 1 }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "Content", "Correct", "QuestionId" },
                values: new object[,]
                {
                    { new Guid("00976f85-b864-4772-b1d5-49ea9e56be40"), "powinien być bardzo słabiutki", false, new Guid("97300d8f-9d5b-4275-b5f4-e7dca0434b34") },
                    { new Guid("15a55009-1420-4c18-8849-96336a7eaa13"), "wchodząc do windy mówimy dzień dobry", false, new Guid("aa2a716c-a5d6-48a4-8c0e-6bbfe2ffe796") },
                    { new Guid("23073c9d-a894-49d7-aede-e2e89b87d50a"), "obydwie odpowiedzi są prawidłowe", false, new Guid("893968ac-c125-4c37-b59a-441de2bafdce") },
                    { new Guid("31590c8b-560f-4552-ad3c-b65d683b34ce"), "kładziemy ją na kolanach", true, new Guid("d2de62f2-d12f-4e23-812f-b26fd485932a") },
                    { new Guid("36eceb3e-aa38-4a00-80d0-df89c977af17"), "odpowiedzi a i b są prawidłowe", true, new Guid("2253e484-e47b-4277-b550-79ff908959cc") },
                    { new Guid("36ffdd1a-c6c4-45b1-8b1f-10080d2a8cee"), "powinien być pewny, ale nie za mocny, w żadnym razie również zbyt słaby", true, new Guid("97300d8f-9d5b-4275-b5f4-e7dca0434b34") },
                    { new Guid("387926f3-4f9d-4809-b571-cebe54b9f6a1"), "zarówno odp a, b jaki i c są prawidłowe", true, new Guid("d9e1965b-799b-4e8c-a721-8fa3c1fb868c") },
                    { new Guid("479fef7c-9f64-4902-bea0-aa8292b5779f"), "w żadnej z tych sytuacji osób nieznajomych nie pozdrawiamy", false, new Guid("aa2a716c-a5d6-48a4-8c0e-6bbfe2ffe796") },
                    { new Guid("4caf9d5c-d675-402b-a1db-1552a6df0220"), "w grupie należy powitać wszystkich tak samo", true, new Guid("1e63cba0-0597-4bdd-a84e-d889d0e89267") },
                    { new Guid("5a45569d-bfa3-47b6-8282-03febf17c4cf"), "pojawiając się w poczekalni u lekarza mówimy dzień dobry", false, new Guid("aa2a716c-a5d6-48a4-8c0e-6bbfe2ffe796") },
                    { new Guid("5c979120-ea9b-4f03-b3d4-f8fc26f4ea2e"), "podwładny wita przełożonego", false, new Guid("d9e1965b-799b-4e8c-a721-8fa3c1fb868c") },
                    { new Guid("6514ec29-72e3-4ec2-b46e-1d65630de093"), "w relacji młodszy – starszy – kolejność jest bez różnicy", false, new Guid("82efba24-cf19-41a5-89af-2265a060374d") },
                    { new Guid("6b6ceeb9-cad9-44b6-abe4-1ae298ec627f"), "odkładamy na bok", false, new Guid("d2de62f2-d12f-4e23-812f-b26fd485932a") },
                    { new Guid("7001c56e-093d-42db-bc3c-6ac985b85875"), "kobieta przedstawia się mężczyźnie", false, new Guid("893968ac-c125-4c37-b59a-441de2bafdce") },
                    { new Guid("70dbae90-644f-4582-bd78-70b04fdf90c7"), "kolejność nie ma znaczenia", false, new Guid("63baba33-48aa-4a33-9fc0-3bf16edf598c") },
                    { new Guid("73c1e81a-4f0d-4112-83fb-150d8b0561b9"), "kobieta – mężczyźnie", false, new Guid("2253e484-e47b-4277-b550-79ff908959cc") },
                    { new Guid("7a5f6878-08dc-4e40-b335-29df7d98334b"), "najpierw wymieniamy imię i nazwisko mężczyzny", true, new Guid("63baba33-48aa-4a33-9fc0-3bf16edf598c") },
                    { new Guid("7e97ff82-1f6f-4b1b-947d-7f2421f6e880"), "starszy podaje dłoń młodszemu", false, new Guid("2253e484-e47b-4277-b550-79ff908959cc") },
                    { new Guid("9291a11d-d6fb-4dd6-99f6-17804215ca73"), "w grupie podają sobie rękę tylko ci którzy się znają", false, new Guid("1e63cba0-0597-4bdd-a84e-d889d0e89267") },
                    { new Guid("99b58dae-9c18-40f4-9514-db7e5ba02435"), "starsza osoba jest przedstawiana młodszej, a następnie młodsza starszej", false, new Guid("82efba24-cf19-41a5-89af-2265a060374d") },
                    { new Guid("9b90c8c3-b7b9-4e14-b478-e0f4c69e9080"), "w każdej z tych sytuacji pozdrawiamy osoby nieznajome", true, new Guid("aa2a716c-a5d6-48a4-8c0e-6bbfe2ffe796") },
                    { new Guid("9cad2531-e2e3-4582-bd56-5d3a5c0ed04d"), "najpierw wymieniamy imię i nazwisko kobiety", false, new Guid("63baba33-48aa-4a33-9fc0-3bf16edf598c") },
                    { new Guid("ab083765-fdf0-4027-8653-e4b33851ce16"), "pierwsze mówią osoby, które się w pomieszczeniu znajdują", true, new Guid("8537c713-995c-4365-8146-dfd18b3283e8") },
                    { new Guid("babe025d-f5e5-4481-8ad1-24257c7b1966"), "wchodzimy do restauracji i mówimy dzień dobry", false, new Guid("aa2a716c-a5d6-48a4-8c0e-6bbfe2ffe796") },
                    { new Guid("bc7b394e-1739-4279-9a81-12a59941554c"), "pierwsza mówi osoba która wchodzi do pomieszczenia, nawet wtedy gdy jest przełożonym", false, new Guid("8537c713-995c-4365-8146-dfd18b3283e8") },
                    { new Guid("be259869-f366-4105-9a47-8ad32fa8e872"), "powinien być bardzo silny", false, new Guid("97300d8f-9d5b-4275-b5f4-e7dca0434b34") },
                    { new Guid("c69f9bcb-5bc8-4802-8706-de4bea1820af"), "za kołnierzyk", false, new Guid("d2de62f2-d12f-4e23-812f-b26fd485932a") },
                    { new Guid("cdb81142-168d-4440-a48e-3339ca7c49ff"), "młodszy pozdrawia starszego", false, new Guid("d9e1965b-799b-4e8c-a721-8fa3c1fb868c") },
                    { new Guid("dd890336-d2cc-4bcc-a9b5-02cdef3ea4d2"), "w grupie podają sobie rękę tylko mężczyźni", false, new Guid("1e63cba0-0597-4bdd-a84e-d889d0e89267") },
                    { new Guid("e8832762-68c6-4420-9688-0f63152332f5"), "młodsza osoba jest przedstawiana starszej, a następnie starsza młodszej", true, new Guid("82efba24-cf19-41a5-89af-2265a060374d") },
                    { new Guid("ece30e97-842a-4ec0-8f08-4f1f49f582d5"), "starszy przedstawia się młodszemu", false, new Guid("893968ac-c125-4c37-b59a-441de2bafdce") },
                    { new Guid("f100d61a-cef8-413f-851c-9f5e13872dea"), "żadna z tych odpowiedzi nie jest prawidłowa", true, new Guid("893968ac-c125-4c37-b59a-441de2bafdce") },
                    { new Guid("f25acb8b-abde-4afe-a29f-59311c9f1bf8"), "mężczyzna kobietę", false, new Guid("d9e1965b-799b-4e8c-a721-8fa3c1fb868c") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("00976f85-b864-4772-b1d5-49ea9e56be40"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("15a55009-1420-4c18-8849-96336a7eaa13"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("23073c9d-a894-49d7-aede-e2e89b87d50a"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("31590c8b-560f-4552-ad3c-b65d683b34ce"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("36eceb3e-aa38-4a00-80d0-df89c977af17"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("36ffdd1a-c6c4-45b1-8b1f-10080d2a8cee"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("387926f3-4f9d-4809-b571-cebe54b9f6a1"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("479fef7c-9f64-4902-bea0-aa8292b5779f"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("4caf9d5c-d675-402b-a1db-1552a6df0220"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("5a45569d-bfa3-47b6-8282-03febf17c4cf"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("5c979120-ea9b-4f03-b3d4-f8fc26f4ea2e"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("6514ec29-72e3-4ec2-b46e-1d65630de093"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("6b6ceeb9-cad9-44b6-abe4-1ae298ec627f"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("7001c56e-093d-42db-bc3c-6ac985b85875"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("70dbae90-644f-4582-bd78-70b04fdf90c7"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("73c1e81a-4f0d-4112-83fb-150d8b0561b9"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("7a5f6878-08dc-4e40-b335-29df7d98334b"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("7e97ff82-1f6f-4b1b-947d-7f2421f6e880"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("9291a11d-d6fb-4dd6-99f6-17804215ca73"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("99b58dae-9c18-40f4-9514-db7e5ba02435"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("9b90c8c3-b7b9-4e14-b478-e0f4c69e9080"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("9cad2531-e2e3-4582-bd56-5d3a5c0ed04d"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("ab083765-fdf0-4027-8653-e4b33851ce16"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("babe025d-f5e5-4481-8ad1-24257c7b1966"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("bc7b394e-1739-4279-9a81-12a59941554c"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("be259869-f366-4105-9a47-8ad32fa8e872"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("c69f9bcb-5bc8-4802-8706-de4bea1820af"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("cdb81142-168d-4440-a48e-3339ca7c49ff"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("dd890336-d2cc-4bcc-a9b5-02cdef3ea4d2"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("e8832762-68c6-4420-9688-0f63152332f5"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("ece30e97-842a-4ec0-8f08-4f1f49f582d5"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("f100d61a-cef8-413f-851c-9f5e13872dea"));

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: new Guid("f25acb8b-abde-4afe-a29f-59311c9f1bf8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("1e63cba0-0597-4bdd-a84e-d889d0e89267"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("2253e484-e47b-4277-b550-79ff908959cc"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("63baba33-48aa-4a33-9fc0-3bf16edf598c"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("82efba24-cf19-41a5-89af-2265a060374d"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("8537c713-995c-4365-8146-dfd18b3283e8"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("893968ac-c125-4c37-b59a-441de2bafdce"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("97300d8f-9d5b-4275-b5f4-e7dca0434b34"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("aa2a716c-a5d6-48a4-8c0e-6bbfe2ffe796"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d2de62f2-d12f-4e23-812f-b26fd485932a"));

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: new Guid("d9e1965b-799b-4e8c-a721-8fa3c1fb868c"));
        }
    }
}
