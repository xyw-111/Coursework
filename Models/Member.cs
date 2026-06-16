using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitStudioGym.Models
{
    // Represents the gym members who are registered in the system
    public class Member
    {
        // Primary key for the members table
        [Key]
        public int MemberID { get; set; }

        // Member first name
        [Required]
        public required string FirstName { get; set; }

        // Member last name
        [Required]
        public required string LastName { get; set; }

        // Member phone number
        [Required]
        public required string PhoneNumber { get; set; }

        // Member email address
        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        // Date when the member joined the gym
        [Required]
        public DateTime DateJoined { get; set; }

        // Foreign key linking member to a membership plan
        public int MembershipPlanID { get; set; }

        // Navigation property for membership plan relationship
        public MembershipPlan? MembershipPlan { get; set; }
    }
}
