using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using UltraGroup.Application.Ports;
using UltraGroup.Domain.Agents.Entity;
using UltraGroup.Domain.Agents.Entity.Dto;
using UltraGroup.Infrastructure.Ports;

namespace UltraGroup.Api.Tests.AgentApi
{
    public class AgentApiTests
    {
        [Fact]
        public async Task GetSingleClientsSuccess()
        {
            await using var webApp = new ApiApp();
            var serviceCollection = webApp.GetServiceCollection();
            using var scope = serviceCollection.CreateScope();

            var agent = new AgentDataBuilder().Build();

            var agentRepository = scope.ServiceProvider.GetRequiredService<IRepository<Agent>>();
            var unitOfWork = scope.ServiceProvider.GetRequiredService<IUnitOfWork>();
            await agentRepository.AddAsync(agent);
            await unitOfWork.SaveAsync(new CancellationTokenSource().Token);

            var client = webApp.CreateClient();

            var agentDto = await client.GetFromJsonAsync<AgentDto>($"/api/agents/{agent.Id}");

            agentDto.Should().NotBeNull();
            agentDto.Id.Should().Be(agent.Id);
            agentDto.Name.Should().Be(agent.Name);
            agentDto.Email.Should().Be(agent.Email);
            agentDto.Phone.Should().Be(agent.Phone);
        }
    }
}
