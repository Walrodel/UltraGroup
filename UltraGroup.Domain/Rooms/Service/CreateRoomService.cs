using UltraGroup.Domain.Common;
using UltraGroup.Domain.Rooms.Entity;
using UltraGroup.Domain.Rooms.Port;

namespace UltraGroup.Domain.Rooms.Service
{
    [DomainService]
    public class CreateRoomService(IRoomRepository roomRepository)
    {
        public async Task<Guid> ExecuteAsync(Room room)
        {
            var hotelCreate = await roomRepository.AddAsync(room);

            return hotelCreate.Id;
        }
    }
}
