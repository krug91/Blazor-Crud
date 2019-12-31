using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BlazorProject.Models
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Email> Email { get; set; }
        public virtual DbSet<EmailDetail> EmailDetail { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity<Email>(entity =>
            {
                entity.Property(e => e.EmailAddress).HasMaxLength(150);
            });

            modelBuilder.Entity<EmailDetail>(entity =>
            {
                entity.ToTable("Email_Detail");

                entity.Property(e => e.Tag).HasMaxLength(150);
            });
        }
    }
}
