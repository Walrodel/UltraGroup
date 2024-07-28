using UltraGroup.Domain.Common;
using UltraGroup.Domain.Travelers.Entity;
using UltraGroup.Domain.Travelers.Port;

namespace UltraGroup.Domain.Travelers.Service
{
    [DomainService]
    public class CreateTravelerService(ITravelerRepository travelerRepository)
    {
        public async Task<Guid> ExecuteAsync(Traveler traveler)
        {
            var hotelCreate = await travelerRepository.AddAsync(traveler);

            return hotelCreate.Id;
        }
    }
}
