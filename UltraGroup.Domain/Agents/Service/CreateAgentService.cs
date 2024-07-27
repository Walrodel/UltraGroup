using UltraGroup.Domain.Agents.Entity;
using UltraGroup.Domain.Agents.Port;
using UltraGroup.Domain.Common;

namespace UltraGroup.Domain.Agents.Service
{
    [DomainService]
    public class CreateAgentService(IAgentRepository agentRepository)
    {

        public async Task<Guid> ExecuteAsync(Agent agent)
        {
            var agentCreate = await agentRepository.AddAsync(agent);

            return agentCreate.Id;
        }
    }
}
