using AutoMapper;
using MediatR;
using UltraGroup.Application.Ports;
using UltraGroup.Domain.Rooms.Entity.Dto;
using UltraGroup.Domain.Rooms.Service;

namespace UltraGroup.Application.Rooms.Command
{
    internal class UpdateRoomHandler(UpdateRoomService updateRoomService, RoomFactory roomFactory, IMapper mapper, IUnitOfWork unitOfWork) : IRequestHandler<UpdateRoomCommand>
    {
        public async Task<Unit> Handle(UpdateRoomCommand request, CancellationToken cancellationToken)
        {
            var roomDto = mapper.Map<RoomCreateDto>(request);
            var rooo = await roomFactory.Create(roomDto);
            await updateRoomService.ExecuteAsync(rooo);
            await unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}
