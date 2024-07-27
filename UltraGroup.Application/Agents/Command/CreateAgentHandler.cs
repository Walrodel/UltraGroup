using MediatR;
using UltraGroup.Application.Ports;
using UltraGroup.Domain.Agents.Entity;
using UltraGroup.Domain.Agents.Service;

namespace UltraGroup.Application.Agents.Command
{
    internal class CreateAgentHandler(CreateAgentService createAgentService, IUnitOfWork unitOfWork) : IRequestHandler<CreateAgentCommand, Guid>
    {
        public async Task<Guid> Handle(CreateAgentCommand request, CancellationToken cancellationToken)
        {
            var agent = new Agent()
            {
                Name = request.Name,
                Email = request.Email,
                Phone = request.Phone,
            };
            var id = await createAgentService.ExecuteAsync(agent);
            await unitOfWork.SaveAsync();
            return id;
        }
    }
}
