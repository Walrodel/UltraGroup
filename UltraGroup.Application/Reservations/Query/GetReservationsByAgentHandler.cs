using AutoMapper;
using MediatR;
using UltraGroup.Application.Reservations.Query.Dto;
using UltraGroup.Domain.Agents.Entity;
using UltraGroup.Domain.Hotels.Entity;
using UltraGroup.Domain.Reservations.Entity;
using UltraGroup.Domain.Reservations.Port;
using UltraGroup.Domain.Rooms.Entity;
using UltraGroup.Domain.Travelers.Entity;

namespace UltraGroup.Application.Reservations.Query
{
    internal class GetReservationsByAgentHandler(IReservationRepository reservationRepository, IMapper mapper) : IRequestHandler<GetReservationsByAgentQuery, IEnumerable<ReservationDto>>
    {
        public async Task<IEnumerable<ReservationDto>> Handle(GetReservationsByAgentQuery request, CancellationToken cancellationToken)
        {
            var reservatios = await reservationRepository.GetManyAsync(reservation => reservation.Room.Hotel.Agent.Id.Equals(request.AgentId),
                $"{nameof(Traveler)},{nameof(Room)},{nameof(EmergencyContact)},{nameof(Room)}.{nameof(Hotel)},{nameof(Room)}.{nameof(Hotel)}.{nameof(Agent)}");

            return mapper.Map<IEnumerable<ReservationDto>>(reservatios);
        }
    }
}
