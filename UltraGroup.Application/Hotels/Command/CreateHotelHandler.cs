using AutoMapper;
using MediatR;
using UltraGroup.Application.Ports;
using UltraGroup.Domain.Hotels.Entity.Dto;
using UltraGroup.Domain.Hotels.Service;

namespace UltraGroup.Application.Hotels.Command
{
    internal class CreateHotelHandler(CreateHotelService createHotelService, HotelFactory hotelFactory, IMapper mapper, IUnitOfWork unitOfWork) : IRequestHandler<CreateHotelCommand, Guid>
    {
        public async Task<Guid> Handle(CreateHotelCommand request, CancellationToken cancellationToken)
        {
            var hotelDto = mapper.Map<HotelCreateDto>(request);
            var hotel = await hotelFactory.Create(hotelDto);
            var id = await createHotelService.ExecuteAsync(hotel);
            await unitOfWork.SaveAsync();
            return id;
        }
    }
}
