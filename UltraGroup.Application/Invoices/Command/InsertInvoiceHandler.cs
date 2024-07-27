﻿using UltraGroup.Application.Invoice.Command.Factory;
using UltraGroup.Application.Ports;
using UltraGroup.Domain.Invoices.Service;
using MediatR;

namespace UltraGroup.Application.Invoice.Command
{
    internal class InsertInvoiceHandler(InvoiceFactory insertInvoiceFactory, InsertInvoiceService insertInvoiceService, IUnitOfWork unitOfWork) : IRequestHandler<InsertInvoiceCommand, Guid>
    {
        public async Task<Guid> Handle(InsertInvoiceCommand request, CancellationToken cancellationToken)
        {
            var invoice = await insertInvoiceFactory.CreateAsync(request);
            var invoiceId = await insertInvoiceService.ExecuteAsync(invoice);
            await unitOfWork.SaveAsync();
            return invoiceId;
        }
    }
}
