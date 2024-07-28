using UltraGroup.Domain.Travelers.Entity;
using UltraGroup.Domain.Travelers.Port;
using UltraGroup.Infrastructure.Ports;

namespace UltraGroup.Infrastructure.Adapters
{
    [Repository]
    public class TravelerSqlRepository(IRepository<Traveler> roomRepository) : ITravelerRepository
    {
        public Task<Traveler> AddAsync(Traveler traveler)
        {
            return roomRepository.AddAsync(traveler);
        }

        public async Task<Traveler> GetByIdAsync(Guid id, string? include = null)
        {
            return await roomRepository.GetOneAsync(id, include);
        }

        public async Task<int> GetCountAsync()
        {
            return await roomRepository.GetCountAsync();
        }

        public async Task UpdateAsync(Traveler traveler)
        {
            roomRepository.UpdateAsync(traveler);
            await Task.CompletedTask;
        }
    }
}
