public class CustomerService {
    private CustomerRepository repository;

    // Constructor injection
    public CustomerService(CustomerRepository repository) {
        this.repository = repository;
    }

    public void getCustomerDetails(int id) {
        Customer customer = repository.findCustomerById(id);
        if (customer != null) {
            System.out.println("Found: " + customer);
        } else {
            System.out.println("Customer not found for ID: " + id);
        }
    }
}
