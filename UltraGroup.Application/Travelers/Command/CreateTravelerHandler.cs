using MediatR;
using UltraGroup.Application.Ports;
using UltraGroup.Domain.Travelers.Entity;
using UltraGroup.Domain.Travelers.Service;

namespace UltraGroup.Application.Travelers.Command
{
    internal class CreateTravelerHandler(CreateTravelerService createTravelerService, IUnitOfWork unitOfWork) : IRequestHandler<CreateTravelerCommand, Guid>
    {
        public async Task<Guid> Handle(CreateTravelerCommand request, CancellationToken cancellationToken)
        {
            var traveler = new Traveler()
            {
                DateOfBirth = request.DateOfBirth,
                DocumentNumber = request.DocumentNumber,
                DocumentType = request.DocumentType,
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Gender = request.Gender,
                Phone = request.Phone
            };

            var id = await createTravelerService.ExecuteAsync(traveler);
            await unitOfWork.SaveAsync();
            return id;
        }
    }
}
