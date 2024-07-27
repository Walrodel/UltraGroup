using AutoMapper;
using MediatR;
using UltraGroup.Application.Ports;
using UltraGroup.Domain.Agents.Entity.Dto;
using UltraGroup.Domain.Agents.Service;

namespace UltraGroup.Application.Agents.Command
{
    internal class UpdateAgentHandler(UpdateAgentService updateAgentService, IMapper mapper, IUnitOfWork unitOfWork) : IRequestHandler<UpdateAgentCommand>
    {
        public async Task<Unit> Handle(UpdateAgentCommand request, CancellationToken cancellationToken)
        {
            var agentDto = mapper.Map<AgentDto>(request);
            await updateAgentService.ExecuteAsync(agentDto);
            await unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}
