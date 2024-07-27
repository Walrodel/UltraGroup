using MediatR;

namespace UltraGroup.Application.Agents.Command
{
    public record CreateAgentCommand(string Name, string Email, string Phone) : IRequest<Guid>;

}
