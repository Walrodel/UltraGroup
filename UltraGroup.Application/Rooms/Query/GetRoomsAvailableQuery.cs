using MediatR;
using UltraGroup.Domain.Rooms.Entity.Dto;

namespace UltraGroup.Application.Rooms.Query
{
    public record GetRoomsAvailableQuery(
        DateOnly CheckInDate,
        DateOnly CheckOutDate,
        short NumberOfPersons,
        string City
        ) : IRequest<IEnumerable<RoomAviableDto>>;

}
