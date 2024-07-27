using AutoMapper;
using MediatR;
using UltraGroup.Domain.Agents.Entity;
using UltraGroup.Domain.Hotels.Entity.Dto;
using UltraGroup.Domain.Hotels.Port;

namespace UltraGroup.Application.Hotels.Query
{
    internal class GetHotelByIdHandler(IHotelRepository hotelRepository, IMapper mapper) : IRequestHandler<GetHotelByIdQuery, HotelDto>
    {
        public async Task<HotelDto> Handle(GetHotelByIdQuery request, CancellationToken cancellationToken)
        {
            var hotel = await hotelRepository.GetByIdAsync(request.Id, nameof(Agent));
            return mapper.Map<HotelDto>(hotel);
        }
    }
}
