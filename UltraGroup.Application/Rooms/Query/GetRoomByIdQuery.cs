using MediatR;
using UltraGroup.Domain.Rooms.Entity.Dto;

namespace UltraGroup.Application.Rooms.Query
{
    public record GetRoomByIdQuery(Guid Id) : IRequest<RoomDto>;

}
