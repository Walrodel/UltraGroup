﻿using UltraGroup.Domain.Invoices.Model.Entity;

namespace UltraGroup.Domain.Invoices.Model.Dto
{
    public record SummaryInvoiceDto
    {
        public Guid Id { get; set; }
        public decimal ValueTotal { get; set; }
        public InvoiceState State { get; set; }
    }
}
