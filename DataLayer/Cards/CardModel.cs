namespace DataLayer.Cards
{
    public record CardModel
    {
        public int Id { get; init; }
        public string Name { get; init; } = "";
        public string Description { get; init; } = "";
        public string? Image { get; set; }
        public DateTime Date { get; init; }
        public int TimeInMinutes { get; init; }
    }
}
