using UltraGroup.Domain.Common;
using UltraGroup.Domain.Travelers.Entity;

namespace UltraGroup.Domain.Reservations.Entity
{
    public class ReservatioinTreavelers : DomainEntity
    {
        Traveler traveler = default!;

        public Traveler Traveler
        {
            get => traveler;
            set
            {
                value.ValidateNull("The traveler should not be null.");
                traveler = value;
            }
        }
        public Guid ReservationId { get; set; }
    }
}
