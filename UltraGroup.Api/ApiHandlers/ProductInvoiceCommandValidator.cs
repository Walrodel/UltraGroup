using UltraGroup.Application.Invoice.Command;
using FluentValidation;

namespace UltraGroup.Api.ApiHandlers
{
    public class ProductInvoiceCommandValidator : AbstractValidator<ProductInvoiceCommand>
    {
        public ProductInvoiceCommandValidator()
        {
            RuleFor(command => command.ProductId)
                .NotEmpty();

            RuleFor(command => command.Quantity)
                .GreaterThan(default(int));
        }
    }
}
