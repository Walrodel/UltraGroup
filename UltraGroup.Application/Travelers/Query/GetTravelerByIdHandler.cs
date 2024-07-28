using AutoMapper;
using MediatR;
using UltraGroup.Application.Ports;
using UltraGroup.Application.Travelers.Query.Dto;
using UltraGroup.Domain.Travelers.Port;

namespace UltraGroup.Application.Travelers.Query
{
    internal class GetTravelerByIdHandler(ITravelerRepository travelerRepository, IMapper mapper, IUnitOfWork unitOfWork) : IRequestHandler<GetTravelerByIdQuery, TravelerDto>
    {
        public async Task<TravelerDto> Handle(GetTravelerByIdQuery request, CancellationToken cancellationToken)
        {
            var traveler = await travelerRepository.GetByIdAsync(request.Id);

            return mapper.Map<TravelerDto>(traveler);
        }
    }
}
