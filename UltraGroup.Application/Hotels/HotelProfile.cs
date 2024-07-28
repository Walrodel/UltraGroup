using AutoMapper;
using UltraGroup.Application.Hotels.Command;
using UltraGroup.Domain.Hotels.Entity;
using UltraGroup.Domain.Hotels.Entity.Dto;

namespace UltraGroup.Application.Hotels
{
    public class HotelProfile : Profile
    {
        public HotelProfile()
        {
            CreateMap<CreateHotelCommand, HotelCreateDto>();
            CreateMap<UpdateHotelCommand, HotelCreateDto>();
            CreateMap<Hotel, HotelDto>();
        }
    }
}
