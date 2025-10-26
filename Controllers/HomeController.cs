using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace MyFirstMvc.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/another-index")]
        public IActionResult AnotherIndex()
        {
            return View();
        }
    }
}
