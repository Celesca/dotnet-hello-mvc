using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.Controllers;

public class ProductController : Controller
{
    // GET
    [Route("/api/product/index")]
    public IActionResult Index()
    {
        return View();
    }
}