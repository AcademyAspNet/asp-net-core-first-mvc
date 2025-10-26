using Microsoft.AspNetCore.Mvc;

namespace MyFirstMvc.Controllers
{
    public class GreetingController : Controller
    {
        [HttpGet("/greeting")]
        public IActionResult Index()
        {
            return View("~/Views/Greeting/Index.cshtml");
        }

        
        public IActionResult ProcessForm([FromForm] string? name, [FromQuery(Name = "loud")] bool? isLoud)
        {
            if (name != null && isLoud != null && isLoud == true)
                name = name.ToUpper();

            return View("~/Views/Greeting/Index.cshtml", name);
        }
    }
}
