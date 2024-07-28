using UltraGroup.Domain.Common;
using UltraGroup.Domain.Reservations.Entity;
using UltraGroup.Domain.Reservations.Port;

namespace UltraGroup.Domain.Reservations.Service
{
    [DomainService]
    public class CreateReservationService(IReservationRepository reservationRepository)
    {
        public async Task<Guid> ExecuteAsync(Reservation reservation)
        {
            var reservationCreate = await reservationRepository.AddAsync(reservation);

            return reservationCreate.Id;
        }
    }
}
