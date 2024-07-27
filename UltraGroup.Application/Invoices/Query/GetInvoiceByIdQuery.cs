using UltraGroup.Application.Invoice.Query.Dto;
using MediatR;

namespace UltraGroup.Application.Invoice.Query
{
    public record GetInvoiceByIdQuery(Guid id) : IRequest<InvoiceDto>;
}
