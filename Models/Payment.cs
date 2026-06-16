using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitStudioGym.Models
{
    // Represents payments made by gym members
    public class Payment
    {
        // Primary key for the payments table
        [Key]
        public int PaymentID { get; set; }

        // Foreign key linking payment to a member
        [ForeignKey("Member")]
        public int MemberID { get; set; }

        // Amount paid by the member
        [Required]
        public decimal Amount { get; set; }

        // Date the payment was made
        [Required]
        public DateTime PaymentDate { get; set; }

        // Payment method used
        [Required]
        public required string PaymentMethod { get; set; }

        // Navigation property for member relationship
        public Member? Member { get; set; }
    }
}
