using UltraGroup.Domain.Common;
using UltraGroup.Domain.Hotels.Port;
using UltraGroup.Domain.Rooms.Entity;
using UltraGroup.Domain.Rooms.Entity.Dto;

namespace UltraGroup.Domain.Rooms.Service
{
    [DomainService]
    public class RoomFactory(IHotelRepository hotelRepository)
    {
        public async Task<Room> Create(RoomCreateDto room)
        {
            var hotel = await hotelRepository.GetByIdAsync(room.HotelId);
            return new Room()
            {
                Id = room.Id,
                Number = room.Number,
                BaseCost = room.CosBaseCost,
                Location = room.Location,
                Tax = room.Tax,
                Type = room.Type,
                Hotel = hotel,
                State = room.State,
            };
        }
    }
}
