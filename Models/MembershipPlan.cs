using System.ComponentModel.DataAnnotations;

namespace FitStudioGym.Models
{
    // Represents membership plans that are offered by the gym
    public class MembershipPlan
    {
        // Primary key for the membership plan table
        [Key]
        public int MembershipPlanID { get; set; }

        // Name of the membership plan
        [Required]
        public required string PlanName { get; set; }

        // Duration of the plan in months
        [Required]
        public int Duration { get; set; }

        // Cost of the membership plan
        [Required]
        public decimal Price { get; set; }
    }
}
