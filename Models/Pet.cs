using System.ComponentModel.DataAnnotations;

namespace BlazorApp3.Models
{
    public class Pet
    {
        [Required(ErrorMessage = "Pet name is required")]
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters")]
        [RegularExpression(@"^[a-zA-Z\s-]+$", ErrorMessage = "Pet name can only contain letters, spaces, and hyphens")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Species is required")]
        public string Species { get; set; } = string.Empty;

        [Required(ErrorMessage = "Breed is required")]
        [StringLength(50, ErrorMessage = "Breed cannot be longer than 50 characters")]
        [RegularExpression(@"^[a-zA-Z\s-]+$", ErrorMessage = "Breed can only contain letters, spaces, and hyphens")]
        public string Breed { get; set; } = string.Empty;

        [Required(ErrorMessage = "Age is required")]
        [Range(0, 30, ErrorMessage = "Age must be between 0 and 30 years")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Weight is required")]
        [Range(0.1, 100, ErrorMessage = "Weight must be between 0.1 and 100 kg")]
        public double Weight { get; set; }

        public string? MedicalHistory { get; set; }

        [Required(ErrorMessage = "Last vaccination date is required")]
        public DateTime? LastVaccinationDate { get; set; }

        [Required(ErrorMessage = "Next check-up date is required")]
        public DateTime? NextCheckupDate { get; set; }
    }
} 