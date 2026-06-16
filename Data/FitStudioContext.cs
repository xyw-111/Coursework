using Microsoft.EntityFrameworkCore;
using FitStudioGym.Models;

namespace FitStudioGym.Data
{
    // Database context for FitStudio Gym Management System
    public class FitStudioContext : DbContext
    {
        // Constructor used to pass database options to the context
        public FitStudioContext(DbContextOptions<FitStudioContext> options)
            : base(options)
        {
        }

        // Members table
        public DbSet<Member> Members { get; set; }

        // Membership plans table
        public DbSet<MembershipPlan> MembershipPlans { get; set; }

        // Payments table
        public DbSet<Payment> Payments { get; set; }

        // Trainers table
        public DbSet<Trainer> Trainers { get; set; }

        // Attendance records table
        public DbSet<Attendance> Attendances { get; set; }

        // Workout plans table
        public DbSet<WorkoutPlan> WorkoutPlans { get; set; }

        // Equipment table
        public DbSet<Equipment> Equipment { get; set; }
    }
}
