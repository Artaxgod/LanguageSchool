﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LanguageSchool.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LanguageSchoolDBEntities : DbContext
    {
        public LanguageSchoolDBEntities()
            : base("name=LanguageSchoolDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Attendances> Attendances { get; set; }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Contracts> Contracts { get; set; }
        public DbSet<Feedbacks> Feedbacks { get; set; }
        public DbSet<Groups> Groups { get; set; }
        public DbSet<HomeworkFiles> HomeworkFiles { get; set; }
        public DbSet<Homeworks> Homeworks { get; set; }
        public DbSet<Languages> Languages { get; set; }
        public DbSet<Messages> Messages { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Schedules> Schedules { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
