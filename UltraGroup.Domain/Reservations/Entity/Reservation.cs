using UltraGroup.Domain.Common;
using UltraGroup.Domain.Rooms.Entity;

namespace UltraGroup.Domain.Reservations.Entity
{
    public class Reservation : DomainEntity
    {
        ICollection<ReservatioinTreavelers> travelers = default!;
        Room room = default!;
        EmergencyContact emergencyContact = default!;
        short numberOfPersons = default;

        public required DateTime Date { get; set; }
        public required DateOnly CheckInDate { get; set; }
        public required DateOnly CheckOutDate { get; set; }

        public required short NumberOfPersons
        {
            get => numberOfPersons;
            set
            {
                value.ValidateGreaterThanZero("The number of persons should be greater than zero.");
                numberOfPersons = value;
            }
        }

        public required ReservationState State { get; set; }

        public required EmergencyContact EmergencyContact
        {
            get => emergencyContact;
            set
            {
                value.ValidateNull("The emergency contact does not exist.");
                emergencyContact = value;
            }
        }

        public required ICollection<ReservatioinTreavelers> Travelers
        {
            get => travelers;
            set
            {
                value.ValidateNull("The travelers should not be null.");
                value.ValidateNotEmpty("The travelers should not be empty.");
                travelers = value;
            }
        }

        public required Room Room
        {
            get => room;
            set
            {
                value.ValidateNull("The room does not exist.");
                room = value;
            }
        }

    }
}
