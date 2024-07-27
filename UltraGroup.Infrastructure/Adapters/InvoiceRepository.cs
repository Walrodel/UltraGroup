using UltraGroup.Domain.Invoices.Model.Entity;
using UltraGroup.Domain.Invoices.Port;
using UltraGroup.Infrastructure.Ports;

namespace UltraGroup.Infrastructure.Adapters
{
    [Repository]
    public class InvoiceRepository(IRepository<Invoice> invoiceRepository) : IInvoiceRepository
    {
        public async Task<Invoice> GetByIdAsync(Guid id) => await invoiceRepository.GetOneAsync(id);

        public async Task<Guid> AddAsync(Invoice invoice)
        {
            var invoiceInsert = await invoiceRepository.AddAsync(invoice);
            return invoiceInsert.Id;
        }

        public void Update(Invoice invoice) => invoiceRepository.UpdateAsync(invoice);

        public Task<Invoice> GetByIdAsync(Guid id, string? include = default)
        {
            return invoiceRepository.GetOneAsync(id, include);
        }
    }
}
