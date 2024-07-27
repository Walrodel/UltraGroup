using UltraGroup.Domain.Invoices.Model.Dto;
using UltraGroup.Domain.Invoices.Model.Entity;
using UltraGroup.Domain.Invoices.Port;
using UltraGroup.Infrastructure.DataSource;
using Dapper;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace UltraGroup.Infrastructure.Adapters
{
    [Repository]
    public class InvoiceSimpleQueryRepository(DataContext dataContext) : IInvoiceSimpleQueryRepository
    {
        private IDbConnection DbConnection => dataContext.Database.GetDbConnection();

        public async Task<IEnumerable<SummaryInvoiceDto>> GetAllCancelAsync()
        {
            var invoices = await DbConnection
                .QueryAsync<SummaryInvoiceDto>(@"select id, ValueTotal, State from Invoice where State = @State",
                    new { State = InvoiceState.Canceled }
                    );
            return invoices;
        }
    }
}
