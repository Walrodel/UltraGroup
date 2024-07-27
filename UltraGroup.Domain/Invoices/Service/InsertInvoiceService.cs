using UltraGroup.Domain.Common;
using UltraGroup.Domain.Invoices.Model.Entity;
using UltraGroup.Domain.Invoices.Port;

namespace UltraGroup.Domain.Invoices.Service
{
    [DomainService]
    public class InsertInvoiceService(IInvoiceRepository invoiceRepository)
    {
        public async Task<Guid> ExecuteAsync(Invoice invoice)
        {
            var invoiceId = await invoiceRepository.AddAsync(invoice);

            return invoiceId;
        }
    }
}
