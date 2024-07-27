using UltraGroup.Domain.Hotels.Entity;
using UltraGroup.Domain.Hotels.Port;
using UltraGroup.Infrastructure.Ports;

namespace UltraGroup.Infrastructure.Adapters
{
    [Repository]
    internal class HotelSqlRepository(IRepository<Hotel> hotelRepository) : IHotelRepository
    {
        public async Task<Hotel> AddAsync(Hotel hotel)
        {
            return await hotelRepository.AddAsync(hotel);
        }

        public async Task<Hotel> GetByIdAsync(Guid id, string? include = default)
        {
            return await hotelRepository.GetOneAsync(id, include);
        }

        public Task<int> GetCountAsync()
        {
            return hotelRepository.GetCountAsync();
        }

        public async Task UpdateAsync(Hotel hotel)
        {
            hotelRepository.UpdateAsync(hotel);
            await Task.CompletedTask;
        }
    }
}
