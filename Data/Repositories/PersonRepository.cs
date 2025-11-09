using Microsoft.Data.SqlClient;
using MyFirstMvc.Data.Entities;
using MyFirstMvc.Models.Dto;

namespace MyFirstMvc.Data.Repositories
{
    public class PersonRepository : IRepository<Person, PersonDto>
    {
        private readonly string _connectionString;

        public PersonRepository(IConfiguration configuration)
        {
            string? connectionString = configuration.GetConnectionString("Default");

            if (string.IsNullOrEmpty(connectionString))
                throw new MissingFieldException("Failed to get 'Default' connection string");

            _connectionString = connectionString;
        }

        public IList<Person> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM [Persons]";

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.HasRows)
                        return [];

                    IList<Person> persons = new List<Person>();

                    int idColumnIndex = reader.GetOrdinal("Id");
                    int nameColumnIndex = reader.GetOrdinal("Name");
                    int salaryColumnIndex = reader.GetOrdinal("Salary");
                    int createdAtColumnIndex = reader.GetOrdinal("CreatedAt");

                    while (reader.Read())
                    {
                        Person person = new Person()
                        {
                            Id = reader.GetInt32(idColumnIndex),
                            Name = reader.GetString(nameColumnIndex),
                            Salary = !reader.IsDBNull(salaryColumnIndex) ? reader.GetDecimal(salaryColumnIndex) : null,
                            CreatedAt = reader.GetDateTime(createdAtColumnIndex)
                        };

                        persons.Add(person);
                    }

                    return persons;
                }
            }
        }

        public void Create(PersonDto personDto)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandText = "INSERT INTO [Persons] ([Name], [Salary]) VALUES (@Name, @Salary)";
                command.Parameters.AddWithValue("@Name", personDto.Name);
                command.Parameters.AddWithValue("@Salary", personDto.Salary ?? 0);

                command.ExecuteNonQuery();
            }
        }
    }
}
