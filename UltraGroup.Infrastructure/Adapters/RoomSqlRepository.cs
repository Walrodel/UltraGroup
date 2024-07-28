using UltraGroup.Domain.Rooms.Entity;
using UltraGroup.Domain.Rooms.Port;
using UltraGroup.Infrastructure.Ports;

namespace UltraGroup.Infrastructure.Adapters
{
    [Repository]
    public class RoomSqlRepository(IRepository<Room> roomRepository) : IRoomRepository
    {
        public Task<Room> AddAsync(Room room)
        {
            return roomRepository.AddAsync(room);
        }

        public async Task<Room> GetByIdAsync(Guid id, string? include = null)
        {
            return await roomRepository.GetOneAsync(id, include);
        }

        public async Task<int> GetCountAsync()
        {
            return await roomRepository.GetCountAsync();
        }

        public async Task UpdateAsync(Room room)
        {
            roomRepository.UpdateAsync(room);
            await Task.CompletedTask;
        }
    }
}
