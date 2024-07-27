using MediatR;
using UltraGroup.Domain.Agents.Entity.Dto;

namespace UltraGroup.Application.Agents.Query
{
    public record GetAgentByIdQuery(Guid Id) : IRequest<AgentDto>;

}
