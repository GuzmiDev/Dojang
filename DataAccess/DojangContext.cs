using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DojangContext : DbContext
    {
        public DbSet<StudentEntity> Students { get; set; }
        public DbSet<BeltEntity> Belts { get; set; }
        public DbSet<ScheduleEntity> Schedules { get; set; }
        public DbSet<PaymentHistoryEntity> PaymentHistory { get; set; }
        public DbSet<PaymentPlanEntity> PaymentPlan { get; set; }
        public DbSet<LogStudentsEntity> logStudents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=localhost\\SQLEXPRESS; Database=Dojang; Trusted_Connection=True");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentEntity>()
                .Property(b => b.Status)
                .HasDefaultValue(true);
            modelBuilder.Entity<BeltEntity>()
                .Property(b => b.Status)
                .HasDefaultValue(true);
            modelBuilder.Entity<ScheduleEntity>()
                .Property(b => b.Status)
                .HasDefaultValue(true);
            modelBuilder.Entity<PaymentHistoryEntity>()
                .Property(b => b.Status)
                .HasDefaultValue(true);
            modelBuilder.Entity<PaymentPlanEntity>()
                .Property(b => b.Status)
                .HasDefaultValue(true);
            modelBuilder.Entity<LogStudentsEntity>()
                .Property(b => b.Status)
                .HasDefaultValue(true);
        }

    }
}
