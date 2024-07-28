using MediatR;
using UltraGroup.Domain.Rooms.Entity;

namespace UltraGroup.Application.Rooms.Command
{
    public record UpdateRoomCommand(
        Guid Id,
        int Number,
        decimal CosBaseCost,
        decimal Tax,
        TypeRoom Type,
        StateRoom State,
        string Location,
        Guid HotelId) : IRequest;
}
