using AutoMapper;
using MediatR;
using UltraGroup.Domain.Rooms.Entity.Dto;
using UltraGroup.Domain.Rooms.Port;

namespace UltraGroup.Application.Rooms.Query
{
    internal class GetRoomsAvailableHandler(IRoomSimpleQueryRepository roomSimpleQueryRepository, IMapper mapper) : IRequestHandler<GetRoomsAvailableQuery, IEnumerable<RoomAviableDto>>
    {
        public async Task<IEnumerable<RoomAviableDto>> Handle(GetRoomsAvailableQuery request, CancellationToken cancellationToken)
        {
            var roomQuery = mapper.Map<RoomQueryDto>(request);
            return await roomSimpleQueryRepository.GetAviavlesAsync(roomQuery);
        }
    }
}
