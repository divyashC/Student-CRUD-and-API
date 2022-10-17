using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Student_CRUD_and_API.Models
{
    public partial class studentdbContext : DbContext
    {
        public studentdbContext()
        {
        }

        public studentdbContext(DbContextOptions<studentdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Student> Students { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Department).HasMaxLength(10);

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .HasColumnName("email");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("phone")
                    .IsFixedLength();

                entity.Property(e => e.StudentId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("student_id")
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
