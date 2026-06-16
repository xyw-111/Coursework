using System.ComponentModel.DataAnnotations;

namespace FitStudioGym.Models
{
    // Represents gym trainers in the system
    public class Trainer
    {
        // Primary key for the trainers table
        [Key]
        public int TrainerID { get; set; }

        // Trainer first name
        [Required]
        public required string FirstName { get; set; }

        // Trainer last name
        [Required]
        public required string LastName { get; set; }

        // Trainer area of specialization
        [Required]
        public required string Specialization { get; set; }

        // Trainer phone number
        [Required]
        public required string PhoneNumber { get; set; }
    }
}
