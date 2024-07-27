namespace UltraGroup.Domain.Hotels.Entity.Dto
{
    public record HotelCreateDto(string Name, string City, string Address, string Description, Guid AgentId, StateHotel State)
    {
        public Guid Id { get; set; }
    }
}
