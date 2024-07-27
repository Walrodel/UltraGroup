using UltraGroup.Domain.Hotels.Entity;

namespace UltraGroup.Domain.Hotels.Port
{
    public interface IHotelRepository
    {
        Task<Hotel> AddAsync(Hotel hotel);
        Task<Hotel> GetByIdAsync(Guid id, string? include = default);
        Task UpdateAsync(Hotel hotel);
        Task<int> GetCountAsync();
    }
}
