using UltraGroup.Domain.Common;

namespace UltraGroup.Domain.Reservations.Entity
{
    public class EmergencyContact : DomainEntity
    {
        public required string FullName { get; set; }
        public required string Phone { get; set; }
    }
}
