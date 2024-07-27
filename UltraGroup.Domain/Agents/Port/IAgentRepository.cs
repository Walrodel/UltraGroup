using UltraGroup.Domain.Agents.Entity;

namespace UltraGroup.Domain.Agents.Port
{
    public interface IAgentRepository
    {
        Task<Agent> AddAsync(Agent agent);
        Task<Agent> GetByIdAsync(Guid id);
        Task UpdateAsync(Agent agent);
        Task<int> GetCountAsync();
    }
}
