using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using UltraGroup.Application.Ports;
using UltraGroup.Domain.Agents.Port;
using UltraGroup.Infrastructure.DataSource.Seed;

namespace UltraGroup.Infrastructure.Extensions
{
    public static class SeedExtension
    {
        public static IHost Seed(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            var services = scope.ServiceProvider;
            var unitOfWork = services.GetRequiredService<IUnitOfWork>();

            var agentRepository = services.GetRequiredService<IAgentRepository>();
            var initializerAgent = new InitializerAgent(agentRepository, unitOfWork);
            initializerAgent.CreateAsync().Wait();

            return host;
        }
    }
}
