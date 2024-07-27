using UltraGroup.Domain.Agents.Port;
using UltraGroup.Domain.Common;
using UltraGroup.Domain.Hotels.Entity;
using UltraGroup.Domain.Hotels.Entity.Dto;

namespace UltraGroup.Domain.Hotels.Service
{
    [DomainService]
    public class HotelFactory(IAgentRepository agentRepository)
    {
        public async Task<Hotel> Create(HotelCreateDto hotel)
        {
            var agent = await agentRepository.GetByIdAsync(hotel.AgentId);
            return new Hotel()
            {
                Id = hotel.Id,
                Name = hotel.Name,
                Address = hotel.Address,
                City = hotel.City,
                State = hotel.State,
                Agent = agent,
                Description = hotel.Description
            };
        }
    }
}
