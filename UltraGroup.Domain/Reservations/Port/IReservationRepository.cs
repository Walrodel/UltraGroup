using System.Linq.Expressions;
using UltraGroup.Domain.Reservations.Entity;

namespace UltraGroup.Domain.Reservations.Port
{
    public interface IReservationRepository
    {
        Task<Reservation> AddAsync(Reservation reservation);
        Task<Reservation> GetByIdAsync(Guid id, string? include = null);
        Task UpdateAsync(Reservation reservation);
        Task<int> GetCountAsync();
        Task<IEnumerable<Reservation>> GetManyAsync(Expression<Func<Reservation, bool>>? filter = default!, string? include = default!);
    }
}
