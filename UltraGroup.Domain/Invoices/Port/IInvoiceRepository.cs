using UltraGroup.Domain.Invoices.Model.Entity;

namespace UltraGroup.Domain.Invoices.Port
{
    public interface IInvoiceRepository
    {
        Task<Guid> AddAsync(Invoice invoice);
        Task<Invoice> GetByIdAsync(Guid id, string? include = default);
        void Update(Invoice invoice);
    }
}
