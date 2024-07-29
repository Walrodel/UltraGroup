using UltraGroup.Application.Travelers.Query.Dto;

namespace UltraGroup.Application.Reservations.Query.Dto
{
    public record ReservatioinTreavelersDto
    {
        public TravelerDto Traveler { get; set; } = default!;
    }
}
