using HelloMVC.Models;
using HelloMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            var CustomerLists = new List<Customer>();
            CustomerLists.Add(new Customer { CustomerID = 1, FullName = "John Doe", Address = "123 Main St" });
            CustomerLists.Add(new Customer { CustomerID = 2, FullName = "Jane Doe", Address = "456 Main St" });
            CustomerLists.Add(new Customer { CustomerID = 3, FullName = "John Smith", Address = "789 Main St" });
            return View(CustomerLists);
        }
        public IActionResult Transaction()
        {
            ViewData["AllCustomers"] = GetAllCustomers();
            ViewData["AllProducts"] = GetAllProducts();
            return View();
        }

        public IActionResult ViewModelTransaction()
        {
            CustomersProductsViewModels data = new CustomersProductsViewModels();
            data.GetCustomers = GetAllCustomers();
            data.GetProducts = GetAllProducts();
            return View(data);
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();

            customers.Add(new Customer
            {
                CustomerID = 1,
                FullName = "John Doe",
                Address = "123 Main St"
            });

            customers.Add(new Customer
            {
                CustomerID = 2,
                FullName = "Jane Doe",
                Address = "456 Main St"
            });

            customers.Add(new Customer
            {
                CustomerID = 3,
                FullName = "John Smith",
                Address = "789 Main St"
            });

            return customers;
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product
            {
                ProductID = 11,
                ProductName = "Laptop",
                ProductPrice = 500
            });

            products.Add(new Product
            {
                ProductID = 12,
                ProductName = "Mouse",
                ProductPrice = 20
            });

            products.Add(new Product
            {
                ProductID = 13,
                ProductName = "Keyboard",
                ProductPrice = 50
            });

            return products;
        }
    }
}
