using UltraGroup.Domain.Hotels.Entity.Dto;

namespace UltraGroup.Domain.Rooms.Entity.Dto
{
    public record RoomDto
    {
        public Guid Id { get; set; }
        public int NumberOfPersons { get; set; }
        public decimal CosBaseCost { get; set; }
        public decimal Tax { get; set; }
        public TypeRoom Type { get; set; }
        public string Location { get; set; } = default!;
        public StateRoom State { get; set; }
        public HotelDto Hotel { get; set; } = default!;
    }
}
