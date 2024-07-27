using MediatR;

namespace UltraGroup.Application.Agents.Command
{
    public record UpdateAgentCommand(Guid Id, string Name, string Email, string Phone) : IRequest;

}
