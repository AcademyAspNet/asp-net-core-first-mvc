namespace MyFirstMvc.Data.Entities
{
    public class Person
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public decimal? Salary { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
