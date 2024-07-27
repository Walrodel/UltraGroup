using MediatR;
using UltraGroup.Domain.Hotels.Entity;

namespace UltraGroup.Application.Hotels.Command
{
    public record UpdateHotelCommand(
        Guid Id,
        string Name,
        string City,
        string Address,
        string Description,
        Guid AgentId,
        StateHotel State) : IRequest;

}
