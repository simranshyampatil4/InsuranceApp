using InsuranceApp.Models;

namespace InsuranceApp.Services
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        Customer Get(int id);
        int Add(Customer customer);
        public Customer Check(int id);

        Customer Update(Customer customer);
        public void Delete(Customer customer);
    }
}
