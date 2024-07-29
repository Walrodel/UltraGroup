using NSubstitute;
using UltraGroup.Domain.Agents.Entity;
using UltraGroup.Domain.Agents.Port;
using UltraGroup.Domain.Agents.Service;
using UltraGroup.Domain.Tests.Agents.Entity;

namespace UltraGroup.Domain.Tests.Agents.Service
{
    public class CreateAgentServiceTests
    {
        readonly IAgentRepository agentRepository;
        readonly CreateAgentService createAgentService;

        public CreateAgentServiceTests()
        {
            agentRepository = Substitute.For<IAgentRepository>();
            createAgentService = new CreateAgentService(agentRepository);
        }

        [Fact]
        public async Task ExecuteAsync_CreateAgent_Success()
        {
            var agent = new AgentDataBuilder().Build();
            agentRepository.AddAsync(Arg.Any<Agent>()).Returns(agent);

            await createAgentService.ExecuteAsync(agent);

            await agentRepository.Received(1).AddAsync(Arg.Is<Agent>(agentCreate => agentCreate == agent));
        }
    }
}
