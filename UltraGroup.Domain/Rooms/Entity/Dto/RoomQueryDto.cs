namespace UltraGroup.Domain.Rooms.Entity.Dto
{
    public record RoomQueryDto(
        DateOnly CheckInDate,
        DateOnly CheckOutDate,
        short NumberOfPersons,
        string City);
}
