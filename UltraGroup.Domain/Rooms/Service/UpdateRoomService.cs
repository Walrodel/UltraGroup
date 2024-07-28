using UltraGroup.Domain.Common;
using UltraGroup.Domain.Rooms.Entity;
using UltraGroup.Domain.Rooms.Port;

namespace UltraGroup.Domain.Rooms.Service
{
    [DomainService]
    public class UpdateRoomService(IRoomRepository roomRepository)
    {
        public async Task ExecuteAsync(Room roomUpdate)
        {
            var room = await roomRepository.GetByIdAsync(roomUpdate.Id);
            room.ValidateNull("The room does not exist.");
            room.Update(roomUpdate);
            await roomRepository.UpdateAsync(room);
        }
    }
}
