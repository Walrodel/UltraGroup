using UltraGroup.Domain.Rooms.Entity.Dto;

namespace UltraGroup.Domain.Rooms.Port
{
    public interface IRoomSimpleQueryRepository
    {
        Task<IEnumerable<RoomAviableDto>> GetAviavlesAsync(RoomQueryDto roomQuery);
    }
}
