using System.ComponentModel.DataAnnotations;

namespace MyFirstMvc.Models.Dto
{
    public class PersonDto
    {
        [Required(ErrorMessage = "Имя Person является обязательным!")]
        [MinLength(2)]
        [MaxLength(128)]
        public string? Name { get; set; }

        [Range(0, 1_000_000)]
        public decimal? Salary { get; set; }
    }
}
