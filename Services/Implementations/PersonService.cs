using MyFirstMvc.Data.Entities;
using MyFirstMvc.Data.Repositories;
using MyFirstMvc.Models.Dto;

namespace MyFirstMvc.Services.Implementations
{
    public class PersonService : IPersonService
    {
        private readonly IRepository<Person, PersonDto> _personRepository;

        public PersonService(IRepository<Person, PersonDto> personRepository)
        {
            _personRepository = personRepository;
        }

        public void CreatePerson(PersonDto personDto)
        {
            _personRepository.Create(personDto);
        }

        public IList<Person> GetPersons()
        {
            return _personRepository.GetAll();
        }
    }
}
