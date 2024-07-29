using UltraGroup.Application.Travelers.Query.Dto;
using UltraGroup.Domain.Reservations.Entity.Dto;
using UltraGroup.Domain.Rooms.Entity.Dto;

namespace UltraGroup.Application.Reservations.Query.Dto
{
    public record ReservationDto
    {
        public Guid Id { get; set; }
        public DateOnly CheckInDate { get; set; }
        public DateOnly CheckOutDate { get; set; }
        public short NumberOfPersons { get; set; }
        public string State { get; set; } = default!;
        public IEnumerable<TravelerDto> Travelers { get; set; } = [];
        public RoomDto Room { get; set; } = default!;
        public EmergencyContactDto EmergencyContact { get; set; } = default!;
    }
}
