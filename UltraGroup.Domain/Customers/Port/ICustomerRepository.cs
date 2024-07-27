using UltraGroup.Domain.Customers.Entity;

namespace UltraGroup.Domain.Customers.Port
{
    public interface ICustomerRepository
    {
        Task<Customer> AddAsync(Entity.Customer customer);
        Task<Customer> GetByIdAsync(Guid id);
        Task<int> GetCountAsync();
    }
}
