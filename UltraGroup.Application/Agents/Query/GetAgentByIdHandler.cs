using AutoMapper;
using MediatR;
using UltraGroup.Domain.Agents.Entity.Dto;
using UltraGroup.Domain.Agents.Port;

namespace UltraGroup.Application.Agents.Query
{
    internal class GetAgentByIdHandler(IAgentRepository agentRepository, IMapper mapper) : IRequestHandler<GetAgentByIdQuery, AgentDto>
    {
        public async Task<AgentDto> Handle(GetAgentByIdQuery request, CancellationToken cancellationToken)
        {
            var agent = await agentRepository.GetByIdAsync(request.Id);

            return mapper.Map<AgentDto>(agent);
        }
    }
}
