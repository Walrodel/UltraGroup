using MediatR;
using UltraGroup.Domain.Reservations.Entity.Dto;

namespace UltraGroup.Application.Reservations.Command
{
    public record CreateReservationCommand(
        DateOnly CheckInDate,
        DateOnly CheckOutDate,
        short NumberOfPersons,
        Guid TravelerId,
        Guid RoomId,
        EmergencyContactDto EmergencyContact
        ) : IRequest<Guid>;

}
