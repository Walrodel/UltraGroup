using MediatR;
using UltraGroup.Application.Reservations.Query.Dto;

namespace UltraGroup.Application.Reservations.Query
{
    public record GetReservationsByAgentQuery(Guid AgentId) : IRequest<IEnumerable<ReservationDto>>;

}
