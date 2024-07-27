using MediatR;

namespace UltraGroup.Application.Invoice.Command
{
    public record InsertInvoiceCommand(
        Guid CustomerId,
        IEnumerable<ProductInvoiceCommand> ProductsInvoice
    ) : IRequest<Guid>;
}
