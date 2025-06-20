using System;

namespace DependencyInjectionExample
{
    // 1. Define Repository Interface
    public interface ICustomerRepository
    {
        string FindCustomerById(int id);
    }

    // 2. Implement Concrete Repository
    public class CustomerRepositoryImpl : ICustomerRepository
    {
        public string FindCustomerById(int id)
        {
            if (id == 1)
                return "Customer: Natasha Kumari";
            else if (id == 2)
                return "Customer: Rahul Mehta";
            else
                return "Customer not found";
        }
    }

    // 3. Define Service Class (depends on repository)
    public class CustomerService
    {
        private readonly ICustomerRepository _repository;

        // 4. Constructor Injection
        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public void ShowCustomer(int id)
        {
            Console.WriteLine(_repository.FindCustomerById(id));
        }
    }

    // 5. Test the Dependency Injection Implementation
    class Program
    {
        static void Main(string[] args)
        {
            // Manually injecting the dependency
            ICustomerRepository repo = new CustomerRepositoryImpl();
            CustomerService service = new CustomerService(repo);

            service.ShowCustomer(1); // Natasha Kumari
            service.ShowCustomer(2); // Rahul Mehta
            service.ShowCustomer(99); // Customer not found
        }
    }
}
