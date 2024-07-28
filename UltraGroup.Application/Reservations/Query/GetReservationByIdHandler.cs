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
    internal class GetReservationByIdHandler(IReservationRepository reservationRepository, IMapper mapper) : IRequestHandler<GetReservationByIdQuery, ReservationDto>
    {
        public async Task<ReservationDto> Handle(GetReservationByIdQuery request, CancellationToken cancellationToken)
        {
            var reservation = await reservationRepository.GetByIdAsync(request.Id,
                $"{nameof(Traveler)},{nameof(Room)},{nameof(EmergencyContact)},{nameof(Room)}.{nameof(Hotel)},{nameof(Room)}.{nameof(Hotel)}.{nameof(Agent)}");

            return mapper.Map<ReservationDto>(reservation);
        }
    }
}
