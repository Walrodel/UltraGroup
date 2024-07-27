using UltraGroup.Domain.Common;
using UltraGroup.Domain.Hotels.Entity;
using UltraGroup.Domain.Hotels.Port;

namespace UltraGroup.Domain.Hotels.Service
{
    [DomainService]
    public class UpdateHotelService(IHotelRepository hotelRepository)
    {
        public async Task ExecuteAsync(Hotel hotelUpdate)
        {
            var hotel = await hotelRepository.GetByIdAsync(hotelUpdate.Id);
            hotel.ValidateNull("The hotel does not exist.");
            hotel.Update(hotelUpdate);
            await hotelRepository.UpdateAsync(hotel);
        }
    }
}
