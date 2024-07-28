using UltraGroup.Domain.Common;
using UltraGroup.Domain.Travelers.Entity;
using UltraGroup.Domain.Travelers.Port;

namespace UltraGroup.Domain.Travelers.Service
{
    [DomainService]
    public class UpdateTravelerService(ITravelerRepository travelerRepository)
    {
        public async Task ExecuteAsync(Traveler travelerUpdate)
        {
            var traveler = await travelerRepository.GetByIdAsync(travelerUpdate.Id);
            traveler.ValidateNull("The traveler does not exist.");
            traveler.Update(travelerUpdate);
            await travelerRepository.UpdateAsync(traveler);
        }
    }
}
