using UltraGroup.Application.Ports;
using UltraGroup.Domain.Agents.Entity;
using UltraGroup.Domain.Agents.Port;

namespace UltraGroup.Infrastructure.DataSource.Seed
{
    public class InitializerAgent(IAgentRepository agentRepository, IUnitOfWork unitOfWork)
    {
        public async Task CreateAsync()
        {
            var count = await agentRepository.GetCountAsync();
            if (count > 0) return;

            Agent agent = new() { Id = Guid.NewGuid(), Name = "Service", Email = "service@email.com", Phone = "123456789" };
            await agentRepository.AddAsync(agent);
            await unitOfWork.SaveAsync();
        }

    }
}
