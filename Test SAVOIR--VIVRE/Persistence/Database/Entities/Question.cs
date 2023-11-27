namespace Test_SAVOIR__VIVRE.Persistence.Database.Entities
{
    public record Question()
    {
        public required Guid Id { get; init; }
        public required string Content { get; init; }
        public required int Points { get; init; }
    }
}
