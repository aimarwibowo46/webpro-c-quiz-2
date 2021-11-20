using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using IntegraKawe.Models;

namespace IntegraKawe.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<StudentCourse>()
                .HasOne(s => s.Student)
                .WithMany(sc => sc.StudentCourses)
                .HasForeignKey(si => si.StudentId);

            builder.Entity<StudentCourse>()
                .HasOne(c => c.Course)
                .WithMany(sc => sc.StudentCourses)
                .HasForeignKey(ci => ci.CourseId);

            base.OnModelCreating(builder);
        }

        public DbSet<IntegraKawe.Models.Student> Student { get; set; }
        public DbSet<IntegraKawe.Models.Course> Course { get; set; }
        public DbSet<IntegraKawe.Models.StudentCourse> StudentCourse { get; set; }
    }
}
