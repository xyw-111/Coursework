using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitStudioGym.Models
{
    // Represents gym attendance records for members
    public class Attendance
    {
        // Primary key for the attendance table
        [Key]
        public int AttendanceID { get; set; }

        // Foreign key linking attendance to a member
        [ForeignKey("Member")]
        public int MemberID { get; set; }

        // Date and time that the member checked in
        [Required]
        public DateTime CheckInTime { get; set; }

        // Navigation property for member relationship
        public Member? Member { get; set; }
    }
}
