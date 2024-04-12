using HelloMVC.Models;
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
    }
}
