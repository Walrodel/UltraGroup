namespace UltraGroup.Domain.Rooms.Entity.Dto
{
    public record RoomCreateDto(int NumberOfPersons, decimal CosBaseCost, decimal Tax, TypeRoom Type, StateRoom State, string Location, Guid HotelId)
    {
        public Guid Id { get; set; }
    }
}
