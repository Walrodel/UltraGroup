using UltraGroup.Domain.Invoices.Model.Dto;
using UltraGroup.Domain.Invoices.Port;
using MediatR;

namespace UltraGroup.Application.Invoice.Query
{
    internal class GetAllCancelHandler(IInvoiceSimpleQueryRepository invoiceSimpleQueryRepository) : IRequestHandler<GetAllCancelQuery, IEnumerable<SummaryInvoiceDto>>
    {
        public async Task<IEnumerable<SummaryInvoiceDto>> Handle(GetAllCancelQuery request, CancellationToken cancellationToken)
        {
            return await invoiceSimpleQueryRepository.GetAllCancelAsync();
        }
    }
}
