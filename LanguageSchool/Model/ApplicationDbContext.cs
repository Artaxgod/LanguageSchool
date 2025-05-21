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
        public LanguageSchoolContext() : base("LanguageSchoolContext") { }

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
            // Настройка связей Many-to-Many
            modelBuilder.Entity<Group>()
                .HasMany(g => g.Clients)
                .WithMany(c => c.Groups)
                .Map(gc => {
                    gc.MapLeftKey("GroupID");
                    gc.MapRightKey("ClientID");
                    gc.ToTable("GroupClients");
                });

            modelBuilder.Entity<Group>()
                .HasMany(g => g.Schedules)
                .WithMany(s => s.Groups)
                .Map(gs => {
                    gs.MapLeftKey("GroupID");
                    gs.MapRightKey("ScheduleID");
                    gs.ToTable("GroupSchedules");
                });

            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.Groups)
                .WithMany(g => g.Teachers)
                .Map(gt => {
                    gt.MapLeftKey("TeacherID");
                    gt.MapRightKey("GroupID");
                    gt.ToTable("GroupTeachers");
                });

            modelBuilder.Entity<Homework>()
                .HasMany(h => h.Groups)
                .WithMany(g => g.Homeworks)
                .Map(hg => {
                    hg.MapLeftKey("HomeworkID");
                    hg.MapRightKey("GroupID");
                    hg.ToTable("GroupHomeworks");
                });
        }
    }
}
