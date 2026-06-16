using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitStudioGym.Models
{
    // Represents workout plans that are assigned to each gym member
    public class WorkoutPlan
    {
        // Primary key for the workout plans table
        [Key]
        public int WorkoutPlanID { get; set; }

        // Foreign key linking workout plan to a member
        [ForeignKey("Member")]
        public int MemberID { get; set; }

        // Foreign key linking workout plan to a trainer
        [ForeignKey("Trainer")]
        public int TrainerID { get; set; }

        // Description of the workout plan
        [Required]
        public required string PlanDetails { get; set; }

        // Date the workout plan was assigned
        [Required]
        public DateTime AssignedDate { get; set; }

        // Navigation property for member relationship
        public Member? Member { get; set; }

        // Navigation property for trainer relationship
        public Trainer? Trainer { get; set; }
    }
}
