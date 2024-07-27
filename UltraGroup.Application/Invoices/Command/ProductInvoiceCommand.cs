namespace UltraGroup.Application.Invoice.Command
{
    public record ProductInvoiceCommand(Guid ProductId, int Quantity);

}
