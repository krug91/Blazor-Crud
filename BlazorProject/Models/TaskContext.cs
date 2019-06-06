using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BlazorProject.Models
{
    public partial class TaskContext : DbContext
    {
        public TaskContext()
        {
        }

        public TaskContext(DbContextOptions<TaskContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Email> Email { get; set; }
        public virtual DbSet<EmailDetail> EmailDetail { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "3.0.0-preview5.19227.1");

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
