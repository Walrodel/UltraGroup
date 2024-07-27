using UltraGroup.Domain.Common;
using UltraGroup.Domain.Hotels.Entity;
using UltraGroup.Domain.Hotels.Port;

namespace UltraGroup.Domain.Hotels.Service
{
    [DomainService]
    public class CreateHotelService(IHotelRepository hotelRepository)
    {
        public async Task<Guid> ExecuteAsync(Hotel hotel)
        {
            var hotelCreate = await hotelRepository.AddAsync(hotel);

            return hotelCreate.Id;
        }
    }
}
