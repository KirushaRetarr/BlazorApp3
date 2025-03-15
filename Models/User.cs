using System.ComponentModel.DataAnnotations;

namespace BlazorApp3.Models
{
    public class User
    {
        [Required(ErrorMessage = "Введите имя")]
        public string Name { get; set; }

        [Range(1, 120, ErrorMessage = "Возраст должен быть от 1 до 120")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Введите Email")]
        [EmailAddress(ErrorMessage = "Неверный формат Email")]
        public string Email { get; set; }
    }
}
