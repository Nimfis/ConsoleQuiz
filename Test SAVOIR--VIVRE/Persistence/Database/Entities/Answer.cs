namespace Test_SAVOIR__VIVRE.Persistence.Database.Entities
{
    public record Answer(Guid Id, Question Question, bool Correct, string Content);
}
