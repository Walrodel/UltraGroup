using UltraGroup.Domain.Invoices.Model.Dto;

namespace UltraGroup.Domain.Invoices.Port
{
    public interface IInvoiceSimpleQueryRepository
    {
        Task<IEnumerable<SummaryInvoiceDto>> GetAllCancelAsync();
    }
}
