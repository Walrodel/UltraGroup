using UltraGroup.Domain.Agents.Entity.Dto;
using UltraGroup.Domain.Agents.Port;
using UltraGroup.Domain.Common;

namespace UltraGroup.Domain.Agents.Service
{
    [DomainService]
    public class UpdateAgentService(IAgentRepository agentRepository)
    {
        public async Task ExecuteAsync(AgentDto agentDto)
        {
            var agent = await agentRepository.GetByIdAsync(agentDto.Id);
            agent.ValidateNull("The agent does not exist.");
            agent.Update(agentDto);
            await agentRepository.UpdateAsync(agent);
        }
    }
}
