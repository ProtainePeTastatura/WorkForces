using System;
using Microsoft.EntityFrameworkCore;
using WebApiCiCd.Entities;

namespace WebApiCiCd.Services
{
    public class UserContext: DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }
        
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Email).IsUnique();
            });

            modelBuilder.Entity<User>()
                .Property(e => e.Role)
                .HasConversion(
                    v => v.ToString(),
                    v => (UserRole) Enum.Parse(typeof(UserRole), v));
            
            modelBuilder.Entity<User>()
                .Property(e => e.WorkExperience)
                .HasDefaultValue(0);
        }
    }
}