using UltraGroup.Application.Travelers.Query.Dto;
using UltraGroup.Domain.Reservations.Entity.Dto;
using UltraGroup.Domain.Rooms.Entity.Dto;

namespace UltraGroup.Application.Reservations.Query.Dto
{
    public record ReservationDto(
        Guid Id,
        DateOnly CheckInDate,
        DateOnly CheckOutDate,
        short NumberOfPersons,
        string State,
        TravelerDto Traveler,
        RoomDto Room,
        EmergencyContactDto EmergencyContact);
}
