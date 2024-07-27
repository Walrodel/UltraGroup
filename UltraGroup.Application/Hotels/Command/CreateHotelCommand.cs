using MediatR;
using UltraGroup.Domain.Hotels.Entity;

namespace UltraGroup.Application.Hotels.Command
{
    public record CreateHotelCommand(string Name, string City, string Address, string Description, Guid AgentId, StateHotel State) : IRequest<Guid>;

}
