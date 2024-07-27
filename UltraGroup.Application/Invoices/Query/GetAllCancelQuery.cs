using UltraGroup.Domain.Invoices.Model.Dto;
using MediatR;

namespace UltraGroup.Application.Invoice.Query
{
    public record GetAllCancelQuery() : IRequest<IEnumerable<SummaryInvoiceDto>>;

}
