using MediatR;
using UltraGroup.Application.Ports;
using UltraGroup.Domain.Travelers.Entity;
using UltraGroup.Domain.Travelers.Service;

namespace UltraGroup.Application.Travelers.Command
{
    internal class UpdateTravelerHandler(UpdateTravelerService updateTravelerService, IUnitOfWork unitOfWork) : IRequestHandler<UpdateTravelerCommand>
    {
        public async Task<Unit> Handle(UpdateTravelerCommand request, CancellationToken cancellationToken)
        {
            var traveler = new Traveler()
            {
                Id = request.Id,
                DateOfBirth = request.DateOfBirth,
                DocumentNumber = request.DocumentNumber,
                DocumentType = request.DocumentType,
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Gender = request.Gender,
                Phone = request.Phone
            };
            await updateTravelerService.ExecuteAsync(traveler);
            await unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}
