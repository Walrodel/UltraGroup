using AutoMapper;
using MediatR;
using UltraGroup.Application.Ports;
using UltraGroup.Domain.Reservations.Entity.Dto;
using UltraGroup.Domain.Reservations.Service;

namespace UltraGroup.Application.Reservations.Command
{
    internal class CreateReservationHandler(
        CreateReservationService createReservationService,
        ReservationFactory reservationFactory,
        IMapper mapper,
        IUnitOfWork unitOfWork) : IRequestHandler<CreateReservationCommand, Guid>
    {
        public async Task<Guid> Handle(CreateReservationCommand request, CancellationToken cancellationToken)
        {
            var reservtioCreate = mapper.Map<ReservationCreateDto>(request);
            var reservation = await reservationFactory.Create(reservtioCreate);
            var id = await createReservationService.ExecuteAsync(reservation);
            await unitOfWork.SaveAsync();
            return id;
        }
    }
}
