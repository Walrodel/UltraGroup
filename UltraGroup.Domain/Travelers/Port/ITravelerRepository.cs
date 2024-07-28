using UltraGroup.Domain.Travelers.Entity;

namespace UltraGroup.Domain.Travelers.Port
{
    public interface ITravelerRepository
    {
        Task<Traveler> AddAsync(Traveler traveler);
        Task<Traveler> GetByIdAsync(Guid id, string? include = default);
        Task UpdateAsync(Traveler traveler);
        Task<int> GetCountAsync();
    }
}
