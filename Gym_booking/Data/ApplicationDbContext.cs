using Gym_booking.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Gym_booking.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<GymClass> GymClass { get; set; } = default!;
        public DbSet<ApplicationUserGymClass> ApplicationUserGymClasses { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ApplicationUserGymClass>()
                .HasKey(t => new { t.ApplicationUserId, t.GymClassId });


            // Relation mellan ApplicationUser och ApplicationUserGymClass
            modelBuilder.Entity<ApplicationUserGymClass>()
                .HasOne(au => au.ApplicationUser)
                .WithMany(a => a.AttendedClasses) 
                .HasForeignKey(au => au.ApplicationUserId);

            // Relation mellan GymClass och ApplicationUserGymClass
            modelBuilder.Entity<ApplicationUserGymClass>()
                .HasOne(gc => gc.GymClass)
                .WithMany(g => g.AttendingMembers) 
                .HasForeignKey(gc => gc.GymClassId);
        }







    }
}
