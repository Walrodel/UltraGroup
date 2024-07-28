using MediatR;
using UltraGroup.Application.Reservations.Query.Dto;

namespace UltraGroup.Application.Reservations.Query
{
    public record GetReservationByIdQuery(Guid Id) : IRequest<ReservationDto>;

}
