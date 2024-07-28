using MediatR;
using UltraGroup.Domain.Travelers.Entity;

namespace UltraGroup.Application.Travelers.Command
{
    public record CreateTravelerCommand(
        string FirstName,
        string LastName,
        DateOnly DateOfBirth,
        Gender Gender,
        DocumentType DocumentType,
        string DocumentNumber,
        string Email,
        string Phone
        ) : IRequest<Guid>;

}
