using AutoMapper;
using MediatR;
using UltraGroup.Application.Ports;
using UltraGroup.Domain.Hotels.Entity.Dto;
using UltraGroup.Domain.Hotels.Service;

namespace UltraGroup.Application.Hotels.Command
{
    internal class UpdateHotelHandler(UpdateHotelService updateHotelService, HotelFactory hotelFactory, IMapper mapper, IUnitOfWork unitOfWork) : IRequestHandler<UpdateHotelCommand>
    {
        public async Task<Unit> Handle(UpdateHotelCommand request, CancellationToken cancellationToken)
        {
            var hotelDto = mapper.Map<HotelCreateDto>(request);
            var hotel = await hotelFactory.Create(hotelDto);
            await updateHotelService.ExecuteAsync(hotel);
            await unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}
