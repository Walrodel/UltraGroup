namespace UltraGroup.Domain.Reservations.Entity.Dto
{
    public record ReservationCreateDto(
        DateOnly CheckInDate,
        DateOnly CheckOutDate,
        short NumberOfPersons,
        Guid TravelerId,
        Guid RoomId,
        EmergencyContactDto EmergencyContact
       );

}
