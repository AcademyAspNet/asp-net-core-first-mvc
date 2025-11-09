using MyFirstMvc.Data;
using MyFirstMvc.Data.Entities;
using MyFirstMvc.Models.Dto;

namespace MyFirstMvc.Services.Implementations
{
    public class PersonService : IPersonService
    {
        private readonly ApplicationDbContext _databaseContext;

        public PersonService(ApplicationDbContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public void CreatePerson(PersonDto personDto)
        {
            Person person = new Person()
            {
                Name = personDto.Name!,
                Salary = personDto.Salary
            };

            _databaseContext.Persons.Add(person);
            _databaseContext.SaveChanges();
        }

        public IList<Person> GetPersons()
        {
            return _databaseContext.Persons.ToList();
        }
    }
}
