using UltraGroup.Domain.Common;
using UltraGroup.Domain.Exceptions;
using UltraGroup.Domain.Hotels.Entity;
using UltraGroup.Domain.Reservations.Entity;
using UltraGroup.Domain.Reservations.Entity.Dto;
using UltraGroup.Domain.Rooms.Entity.Dto;
using UltraGroup.Domain.Rooms.Port;
using UltraGroup.Domain.Travelers.Port;

namespace UltraGroup.Domain.Reservations.Service
{
    [DomainService]
    public class ReservationFactory(ITravelerRepository travelerRepository, IRoomRepository roomRepository, IRoomSimpleQueryRepository roomSimpleQueryRepository)
    {
        public async Task<Reservation> Create(ReservationCreateDto reservationCreate)
        {
            var travelers = new List<ReservatioinTreavelers>();
            foreach (var travelerId in reservationCreate.Travelers)
            {
                var traveler = await travelerRepository.GetByIdAsync(travelerId);
                travelers.Add(new ReservatioinTreavelers { Traveler = traveler });
            }

            var room = await roomRepository.GetByIdAsync(reservationCreate.RoomId, nameof(Hotel));
            var reservation = new Reservation
            {
                Date = DateTime.Now,
                CheckInDate = reservationCreate.CheckInDate,
                CheckOutDate = reservationCreate.CheckOutDate,
                NumberOfPersons = reservationCreate.NumberOfPersons,
                State = ReservationState.Requested,
                Travelers = travelers,
                Room = room,
                EmergencyContact = new() { FullName = reservationCreate.EmergencyContact.FullName, Phone = reservationCreate.EmergencyContact.Phone }
            };
            var roomQuery = new RoomQueryDto(reservationCreate.CheckInDate, reservationCreate.CheckOutDate, reservationCreate.NumberOfPersons, room.Hotel.City);
            var roomsAvailable = await roomSimpleQueryRepository.GetAvailableAsync(roomQuery);
            if (!roomsAvailable.Any(roomAviavle => roomAviavle.Id.Equals(room.Id)))
            {
                throw new CoreBusinessException("The room not is available.");
            }

            return reservation;
        }
    }
}
