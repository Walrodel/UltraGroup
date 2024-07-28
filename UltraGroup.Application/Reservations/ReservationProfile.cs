using AutoMapper;
using UltraGroup.Application.Reservations.Command;
using UltraGroup.Application.Reservations.Query.Dto;
using UltraGroup.Domain.Reservations.Entity;
using UltraGroup.Domain.Reservations.Entity.Dto;

namespace UltraGroup.Application.Reservations
{
    public class ReservationProfile : Profile
    {
        public ReservationProfile()
        {
            CreateMap<CreateReservationCommand, ReservationCreateDto>();
            CreateMap<EmergencyContact, EmergencyContactDto>();
            CreateMap<Reservation, ReservationDto>();
        }
    }
}
