namespace UltraGroup.Domain.Rooms.Entity.Dto
{
    public record RoomAviableDto
    {
        public Guid Id { get; set; }
        public int NumberOfPersons { get; set; }
        public decimal CosBaseCost { get; set; }
        public decimal Tax { get; set; }
        public string Type { get; set; } = default!;
        public string Location { get; set; } = default!;
        public string State { get; set; } = default!;
        public string NameHotel { get; set; } = default!;
        public string City { get; set; } = default!;
        public string Address { get; set; } = default!;
    }
}
