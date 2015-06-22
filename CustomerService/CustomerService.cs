using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService
{
    public class CustomerService
    {
        private ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public Customer GetCustomer(int id)
        {
            return _repository.GetCustomer(id);
        }
    }

    public interface ICustomerRepository
    {
        Customer GetCustomer(int id);
    }

    public class Customer
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
}
