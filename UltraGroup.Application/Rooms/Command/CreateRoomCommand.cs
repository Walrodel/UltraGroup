using MediatR;
using UltraGroup.Domain.Rooms.Entity;

namespace UltraGroup.Application.Rooms.Command
{
    public record CreateRoomCommand(
        int Number,
        decimal CosBaseCost,
        decimal Tax,
        TypeRoom Type,
        StateRoom State,
        string Location,
        Guid HotelId) : IRequest<Guid>;
}
