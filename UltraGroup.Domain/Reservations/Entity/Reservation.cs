using UltraGroup.Domain.Common;
using UltraGroup.Domain.Rooms.Entity;
using UltraGroup.Domain.Travelers.Entity;

namespace UltraGroup.Domain.Reservations.Entity
{
    public class Reservation : DomainEntity
    {
        Traveler traveler = default!;
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

        public required Traveler Traveler
        {
            get => traveler;
            set
            {
                value.ValidateNull("The traveler does not exist.");
                traveler = value;
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
