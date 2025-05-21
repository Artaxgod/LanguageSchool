using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LanguageSchool.Model.Entities;

namespace LanguageSchool.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("LanguageSchoolDB") { }

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
            // Связь Users -> Clients
            modelBuilder.Entity<User>()
                .HasOptional(u => u.Client)
                .WithRequired(c => c.User)
                .WillCascadeOnDelete(false);

            // Связь Users -> Teachers
            modelBuilder.Entity<User>()
                .HasOptional(u => u.Teacher)
                .WithRequired(t => t.User)
                .WillCascadeOnDelete(false);

            // Связь Clients -> GroupClients
            modelBuilder.Entity<Client>()
                .HasMany(c => c.GroupClients)
                .WithRequired(gc => gc.Client)
                .HasForeignKey(gc => gc.ClientID)
                .WillCascadeOnDelete(false);

            // Связь Schedules -> GroupSchedules
            modelBuilder.Entity<Schedule>()
                .HasMany(s => s.GroupSchedules)
                .WithRequired(gs => gs.Schedule)
                .HasForeignKey(gs => gs.ScheduleID)
                .WillCascadeOnDelete(false);

            // Связь Groups -> GroupClients
            modelBuilder.Entity<Group>()
                .HasMany(g => g.GroupClients)
                .WithRequired(gc => gc.Group)
                .HasForeignKey(gc => gc.GroupID)
                .WillCascadeOnDelete(false);
        }
    }
}
