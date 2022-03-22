using Microsoft.EntityFrameworkCore;
using PerformanceAppraisal.EntityCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceAppraisal.EntityCore
{
    public class PerformanceAppraisalDbContext : DbContext
    {
        public PerformanceAppraisalDbContext(DbContextOptions<PerformanceAppraisalDbContext> options)
           : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<JobPosition> JobPosition { get; set; }
        public DbSet<WorkAnnualPlan> WorkAnnualPlan { get; set; }
        public DbSet<Objective> Objectives { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<AppraisalActivity> AppraisalActivities { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<AppraisalSkill> AppraisalSkills { get; set; }
        public DbSet<Period> Period { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WorkAnnualPlan>(entity =>
            {
                entity
                .HasOne(a => a.Supervisor)
                .WithMany(a => a.WorkAnnualPlanForSupervisors)
                .HasForeignKey(a => a.SupervisorId)
                .OnDelete(DeleteBehavior.Restrict);

                entity
                .HasOne(a => a.Employee)
                .WithMany(a => a.WorkAnnualPlanForEmployees)
                .HasForeignKey(a => a.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            });
        }

    }
}
