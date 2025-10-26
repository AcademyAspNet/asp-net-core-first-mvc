namespace MyFirstMvc.Models
{
    public class RandomNumberViewModel
    {
        public required int RandomNumber { get; set; }

        public string GetMessage()
        {
            return $"Случайное число: {RandomNumber}";
        }
    }
}
