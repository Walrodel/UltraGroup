using UltraGroup.Domain.Customers.Entity;
using UltraGroup.Domain.Customers.Port;
using UltraGroup.Infrastructure.Ports;

namespace UltraGroup.Infrastructure.Adapters
{
    [Repository]
    public class CustomerRepository(IRepository<Customer> custumerRepository) : ICustomerRepository
    {
        public async Task<Customer> AddAsync(Customer customer) => await custumerRepository.AddAsync(customer);

        public async Task<Customer> GetByIdAsync(Guid id) => await custumerRepository.GetOneAsync(id);

        public async Task<int> GetCountAsync() => await custumerRepository.GetCountAsync();
    }
}
