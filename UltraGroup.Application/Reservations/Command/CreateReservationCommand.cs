using MediatR;
using UltraGroup.Domain.Reservations.Entity.Dto;

namespace UltraGroup.Application.Reservations.Command
{
    public record CreateReservationCommand(
        DateOnly CheckInDate,
        DateOnly CheckOutDate,
        short NumberOfPersons,
        IEnumerable<Guid> Travelers,
        Guid RoomId,
        EmergencyContactDto EmergencyContact
        ) : IRequest<Guid>;

}
