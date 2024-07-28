using UltraGroup.Domain.Rooms.Entity;

namespace UltraGroup.Domain.Rooms.Port
{
    public interface IRoomRepository
    {
        Task<Room> AddAsync(Room room);
        Task<Room> GetByIdAsync(Guid id, string? include = default);
        Task UpdateAsync(Room room);
        Task<int> GetCountAsync();
    }
}
