using UltraGroup.Domain.Travelers.Entity;
using UltraGroup.Domain.Travelers.Port;
using UltraGroup.Infrastructure.Ports;

namespace UltraGroup.Infrastructure.Adapters
{
    [Repository]
    public class TravelerSqlRepository(IRepository<Traveler> travelerRepository) : ITravelerRepository
    {
        public Task<Traveler> AddAsync(Traveler traveler)
        {
            return travelerRepository.AddAsync(traveler);
        }

        public async Task<Traveler> GetByIdAsync(Guid id, string? include = null)
        {
            return await travelerRepository.GetOneAsync(id, include);
        }

        public async Task<int> GetCountAsync()
        {
            return await travelerRepository.GetCountAsync();
        }

        public async Task UpdateAsync(Traveler traveler)
        {
            travelerRepository.UpdateAsync(traveler);
            await Task.CompletedTask;
        }
    }
}
