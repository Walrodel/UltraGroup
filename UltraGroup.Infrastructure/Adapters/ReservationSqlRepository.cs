using System.Linq.Expressions;
using UltraGroup.Domain.Reservations.Entity;
using UltraGroup.Domain.Reservations.Port;
using UltraGroup.Infrastructure.Ports;

namespace UltraGroup.Infrastructure.Adapters
{
    [Repository]
    public class ReservationSqlRepository(IRepository<Reservation> reservationRepository) : IReservationRepository
    {
        public async Task<Reservation> AddAsync(Reservation reservation)
        {
            return await reservationRepository.AddAsync(reservation);
        }

        public async Task<Reservation> GetByIdAsync(Guid id, string? include = null)
        {
            return await reservationRepository.GetOneAsync(id, include);
        }

        public async Task<int> GetCountAsync()
        {
            return await reservationRepository.GetCountAsync();
        }

        public async Task<IEnumerable<Reservation>> GetManyAsync(Expression<Func<Reservation, bool>>? filter = default!, string? include = default)
        {
            return await reservationRepository.GetManyAsync(filter, includeStringProperties: include!);
        }

        public async Task UpdateAsync(Reservation reservation)
        {
            reservationRepository.UpdateAsync(reservation);
            await Task.CompletedTask;
        }
    }
}
