using UltraGroup.Domain.Common;
using UltraGroup.Domain.Reservations.Entity;
using UltraGroup.Domain.Reservations.Entity.Dto;
using UltraGroup.Domain.Rooms.Port;
using UltraGroup.Domain.Travelers.Port;

namespace UltraGroup.Domain.Reservations.Service
{
    [DomainService]
    public class ReservationFactory(ITravelerRepository travelerRepository, IRoomRepository roomRepository)
    {
        public async Task<Reservation> Create(ReservationCreateDto reservationCreate)
        {
            var traveler = await travelerRepository.GetByIdAsync(reservationCreate.TravelerId);
            var room = await roomRepository.GetByIdAsync(reservationCreate.RoomId);
            var reservation = new Reservation
            {
                Date = DateTime.Now,
                CheckInDate = reservationCreate.CheckInDate,
                CheckOutDate = reservationCreate.CheckOutDate,
                NumberOfPersons = reservationCreate.NumberOfPersons,
                State = ReservationState.Requested,
                Traveler = traveler,
                Room = room,
                EmergencyContact = new() { FullName = reservationCreate.EmergencyContact.FullName, Phone = reservationCreate.EmergencyContact.Phone }
            };

            return reservation;
        }
    }
}
