using Microsoft.AspNetCore.Mvc;
using MyFirstMvc.Data.Entities;
using MyFirstMvc.Data.Repositories;

namespace MyFirstMvc.Controllers
{
    [Route("/persons")]
    public class PersonController : Controller
    {
        private readonly IRepository<Person> _personRepository;

        public PersonController(IRepository<Person> personRepository)
        {
            _personRepository = personRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IList<Person> persons = _personRepository.GetAll();
            return View(persons);
        }
    }
}
