namespace UltraGroup.Domain.Rooms.Entity.Dto
{
    public record RoomAviableDto
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public decimal CosBaseCost { get; set; }
        public decimal Tax { get; set; }
        public TypeRoom Type { get; set; }
        public string Location { get; set; } = default!;
        public StateRoom State { get; set; }
        public string NameHotel { get; set; } = default!;
        public string City { get; set; } = default!;
        public string Address { get; set; } = default!;
    }
}
