using MediatR;
using UltraGroup.Domain.Hotels.Entity.Dto;

namespace UltraGroup.Application.Hotels.Query
{
    public record GetHotelByIdQuery(Guid Id) : IRequest<HotelDto>;

}
