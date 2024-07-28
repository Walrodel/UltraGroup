namespace UltraGroup.Domain.Rooms.Entity.Dto
{
    public record RoomDto
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public decimal CosBaseCost { get; set; }
        public decimal Tax { get; set; }
        public TypeRoom Type { get; set; }
        public string Location { get; set; } = default!;
        public StateRoom State { get; set; }
        public Guid HotelId { get; set; }
    }
}
