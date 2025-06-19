public class DependencyInjectionTest {
    public static void main(String[] args) {
        // Manually creating the dependency
        CustomerRepository repository = new CustomerRepositoryImpl();

        // Injecting dependency into service
        CustomerService service = new CustomerService(repository);

        // Using the service
        service.getCustomerDetails(1);  // Existing customer
        service.getCustomerDetails(3);  // Not found
    }
}

