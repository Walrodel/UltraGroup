using UltraGroup.Domain.Travelers.Entity;

namespace UltraGroup.Application.Travelers.Query.Dto
{
    public record TravelerDto(
        Guid Id,
        string FirstName,
        string LastName,
        DateOnly DateOfBirth,
        Gender Gender,
        DocumentType DocumentType,
        string DocumentNumber,
        string Email,
        string Phone);
}
