using MediatR;
using UltraGroup.Application.Travelers.Query.Dto;

namespace UltraGroup.Application.Travelers.Query
{
    public record GetTravelerByIdQuery(Guid Id) : IRequest<TravelerDto>;

}
