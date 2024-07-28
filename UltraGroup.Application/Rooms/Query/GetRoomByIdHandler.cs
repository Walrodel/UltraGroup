using AutoMapper;
using MediatR;
using UltraGroup.Domain.Agents.Entity;
using UltraGroup.Domain.Hotels.Entity;
using UltraGroup.Domain.Rooms.Entity.Dto;
using UltraGroup.Domain.Rooms.Port;

namespace UltraGroup.Application.Rooms.Query
{
    internal class GetRoomByIdHandler(IRoomRepository roomRepository, IMapper mapper) : IRequestHandler<GetRoomByIdQuery, RoomDto>
    {
        public async Task<RoomDto> Handle(GetRoomByIdQuery request, CancellationToken cancellationToken)
        {
            var room = await roomRepository.GetByIdAsync(request.Id,
                $"{nameof(Hotel)},{nameof(Hotel)}.{nameof(Agent)}");

            return mapper.Map<RoomDto>(room);
        }
    }
}
