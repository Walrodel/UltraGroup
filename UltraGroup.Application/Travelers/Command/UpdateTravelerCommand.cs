using MediatR;
using UltraGroup.Domain.Travelers.Entity;

namespace UltraGroup.Application.Travelers.Command
{
    public record UpdateTravelerCommand(
        Guid Id,
        string FirstName,
        string LastName,
        DateOnly DateOfBirth,
        Gender Gender,
        DocumentType DocumentType,
        string DocumentNumber,
        string Email,
        string Phone
        ) : IRequest;

}
