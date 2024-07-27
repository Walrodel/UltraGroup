using MediatR;

namespace UltraGroup.Application.Invoice.Command
{
    public record CancelInvoiceCommand(Guid id) : IRequest;

}
