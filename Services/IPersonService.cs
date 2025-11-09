using MyFirstMvc.Data.Entities;
using MyFirstMvc.Models.Dto;

namespace MyFirstMvc.Services
{
    public interface IPersonService
    {
        IList<Person> GetPersons();

        void CreatePerson(PersonDto personDto);
    }
}
