using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LanguageSchool.Model.Entities;

namespace LanguageSchool.Model
{
    public class LanguageSchoolContext : DbContext
    {
        public LanguageSchoolContext() : base("LanguageSchoolDB") { }

        public DbSet<User> Users { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Настройка связей
            modelBuilder.Entity<Client>()
                .HasRequired(c => c.User)
                .WithMany()
                .HasForeignKey(c => c.UserID);

            modelBuilder.Entity<Teacher>()
                .HasRequired(t => t.User)
                .WithMany()
                .HasForeignKey(t => t.UserID);

            modelBuilder.Entity<Group>()
                .HasRequired(g => g.Language)
                .WithMany()
                .HasForeignKey(g => g.LanguageID);

            modelBuilder.Entity<Schedule>()
                .HasRequired(s => s.Teacher)
                .WithMany()
                .HasForeignKey(s => s.TeacherID);

            modelBuilder.Entity<Attendance>()
                .HasRequired(a => a.Client)
                .WithMany()
                .HasForeignKey(a => a.ClientID);

            modelBuilder.Entity<Attendance>()
                .HasRequired(a => a.Schedule)
                .WithMany()
                .HasForeignKey(a => a.ScheduleID);

            modelBuilder.Entity<Contract>()
                .HasRequired(c => c.Client)
                .WithMany()
                .HasForeignKey(c => c.ClientID);

            modelBuilder.Entity<Contract>()
                .HasRequired(c => c.Service)
                .WithMany()
                .HasForeignKey(c => c.ServiceID);

            modelBuilder.Entity<Message>()
                .HasRequired(m => m.Client)
                .WithMany()
                .HasForeignKey(m => m.ClientID);

            modelBuilder.Entity<Message>()
                .HasRequired(m => m.Teacher)
                .WithMany()
                .HasForeignKey(m => m.TeacherID);

            modelBuilder.Entity<Feedback>()
                .HasRequired(f => f.User)
                .WithMany()
                .HasForeignKey(f => f.UserID);
        }
    }
}
