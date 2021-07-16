namespace Propella.Domain
{
    public record Property
    {
        public string? BuildingType { get; init; }
        public string? Address { get; init; }
        public int Bedrooms { get; init; }
    }
}