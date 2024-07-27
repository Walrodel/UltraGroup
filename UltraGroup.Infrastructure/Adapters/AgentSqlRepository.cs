using UltraGroup.Domain.Agents.Entity;
using UltraGroup.Domain.Agents.Port;
using UltraGroup.Infrastructure.Ports;

namespace UltraGroup.Infrastructure.Adapters
{
    [Repository]
    public class AgentSqlRepository(IRepository<Agent> agentRepository) : IAgentRepository
    {
        public async Task<Agent> AddAsync(Agent agent)
        {
            return await agentRepository.AddAsync(agent);
        }

        public async Task<Agent> GetByIdAsync(Guid id)
        {
            return await agentRepository.GetOneAsync(id);
        }

        public Task<int> GetCountAsync()
        {
            return agentRepository.GetCountAsync();
        }

        public async Task UpdateAsync(Agent agent)
        {
            agentRepository.UpdateAsync(agent);
            await Task.CompletedTask;
        }
    }
}
