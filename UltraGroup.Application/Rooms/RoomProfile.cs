using AutoMapper;
using UltraGroup.Application.Rooms.Command;
using UltraGroup.Domain.Rooms.Entity;
using UltraGroup.Domain.Rooms.Entity.Dto;

namespace UltraGroup.Application.Rooms
{
    public class RoomProfile : Profile
    {
        public RoomProfile()
        {
            CreateMap<CreateRoomCommand, RoomCreateDto>();
            CreateMap<UpdateRoomCommand, RoomCreateDto>();
            CreateMap<Room, RoomDto>()
                 .ForMember(dest => dest.HotelId, config => config.MapFrom(src => src.Hotel.Id));
        }
    }
}
