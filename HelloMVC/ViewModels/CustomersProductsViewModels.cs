using HelloMVC.Models;

namespace HelloMVC.ViewModels
{
    public class CustomersProductsViewModels
    {
        public IEnumerable<Customer> GetCustomers { get; set; }
        public IEnumerable<Product> GetProducts { get; set; }
    }
}
