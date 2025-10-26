using Microsoft.AspNetCore.Mvc;
using MyFirstMvc.Models;

namespace MyFirstMvc.Controllers
{
    [Route("/random")]
    public class RandomController : Controller
    {
        private readonly Random _random;

        public RandomController()
        {
            _random = new Random();
        }

        [HttpGet("integer")]
        public int Integer()
        {
            return _random.Next();
        }

        [HttpGet("double")]
        public double Double()
        {
            return _random.NextDouble();
        }
    }
}
