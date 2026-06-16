using System.ComponentModel.DataAnnotations;

namespace FitStudioGym.Models
{
    // Represents gym equipment that available for use in the gym
    public class Equipment
    {
        // Primary key for the equipment table
        [Key]
        public int EquipmentID { get; set; }

        // Name of the equipment
        [Required]
        public required string EquipmentName { get; set; }

        // Current status of the equipment
        [Required]
        public required string Status { get; set; }

        // Date when the equipment was last maintained
        [Required]
        public DateTime LastMaintenanceDate { get; set; }
    }
}
