using Microsoft.AspNetCore.Mvc;
using MyFirstMvc.Data.Entities;
using MyFirstMvc.Data.Repositories;
using MyFirstMvc.Models.Dto;
using MyFirstMvc.Services;

namespace MyFirstMvc.Controllers
{
    [Route("/persons")]
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IList<Person> persons = _personService.GetPersons();
            return View(persons);
        }

        [HttpGet("create")]
        public IActionResult CreateForm()
        {
            return View(new PersonDto());
        }

        [HttpPost("create")]
        public IActionResult ProcessCreateForm([FromForm] PersonDto personDto)
        {
            if (!ModelState.IsValid)
                return View("~/Views/Person/CreateForm.cshtml", personDto);

            _personService.CreatePerson(personDto);

            return RedirectToAction(nameof(GetAll));
        }
    }
}
