namespace UltraGroup.Domain.Reservations.Entity.Dto
{
    public record ReservationCreateDto(
        DateOnly CheckInDate,
        DateOnly CheckOutDate,
        short NumberOfPersons,
        IEnumerable<Guid> Travelers,
        Guid RoomId,
        EmergencyContactDto EmergencyContact
       );

}
