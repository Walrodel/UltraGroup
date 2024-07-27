namespace UltraGroup.Domain.Hotels.Entity.Dto
{
    public record HotelDto(Guid Id, string Name, string City, string Address, string Description, string State, Guid AgentId);

}
