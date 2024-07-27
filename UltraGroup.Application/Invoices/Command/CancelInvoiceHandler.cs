using UltraGroup.Application.Ports;
using UltraGroup.Domain.Invoices.Service;
using MediatR;

namespace UltraGroup.Application.Invoice.Command
{
    internal class CancelInvoiceHandler(CancelInvoiceService cancelInvoiceService, IUnitOfWork unitOfWork) : IRequestHandler<CancelInvoiceCommand>
    {
        public async Task<Unit> Handle(CancelInvoiceCommand request, CancellationToken cancellationToken)
        {
            await cancelInvoiceService.ExecuteAsync(request.id);
            await unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}
