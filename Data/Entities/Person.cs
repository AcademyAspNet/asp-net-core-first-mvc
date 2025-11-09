using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MyFirstMvc.Data.Entities
{
    public class Person
    {
        public int Id { get; set; }

        [MaxLength(128)]
        public required string Name { get; set; }

        [Precision(10, 2)]
        public decimal? Salary { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
