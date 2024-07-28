using AutoMapper;
using UltraGroup.Application.Travelers.Query.Dto;
using UltraGroup.Domain.Travelers.Entity;

namespace UltraGroup.Application.Travelers
{
    public class TravelerProfile : Profile
    {
        public TravelerProfile()
        {
            CreateMap<Traveler, TravelerDto>();
        }
    }
}
