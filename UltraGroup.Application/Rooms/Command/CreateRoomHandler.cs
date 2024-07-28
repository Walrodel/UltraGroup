using AutoMapper;
using MediatR;
using UltraGroup.Application.Ports;
using UltraGroup.Domain.Rooms.Entity.Dto;
using UltraGroup.Domain.Rooms.Service;

namespace UltraGroup.Application.Rooms.Command
{
    internal class CreateRoomHandler(CreateRoomService createRoomService, RoomFactory roomFactory, IMapper mapper, IUnitOfWork unitOfWork) : IRequestHandler<CreateRoomCommand, Guid>
    {
        public async Task<Guid> Handle(CreateRoomCommand request, CancellationToken cancellationToken)
        {
            var roomDto = mapper.Map<RoomCreateDto>(request);
            var rooo = await roomFactory.Create(roomDto);
            var id = await createRoomService.ExecuteAsync(rooo);
            await unitOfWork.SaveAsync();
            return id;
        }
    }
}
