namespace Test_SAVOIR__VIVRE.Persistence.Database.Entities
{
    public record Answer()
    {
        public required Guid Id { get; init; }
        public required Guid QuestionId { get; init; }
        public Question Question { get; init; }
        public required bool Correct { get; init; }
        public required string Content { get; init; }
    }
}
