using System;
using BreakTracking.Domain.Models;
using System.Data.Entity;
using System.Linq;

namespace BreakTracking.Context
{
    public class BreakTrackingContext : DbContext
    {
        // Your context has been configured to use a 'BreakTrackingContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BreakTracking.Context.BreakTrackingContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'BreakTrackingContext' 
        // connection string in the application configuration file.
        public BreakTrackingContext()
            : base("name=BreakTrackingContext")
        {
           
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<WorkTime> WorkTimes { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var worktime = modelBuilder.Entity<WorkTime>();
            worktime.ToTable("WorkTime");

            worktime.HasKey(d => new { d.Id });


            worktime.Property(d => d.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);


            var employee = modelBuilder.Entity<Employee>();

            employee.ToTable("Employee");
            employee.HasKey(d => new { d.Id });
            employee.HasMany(h => h.WorkTimes);




            //worktime.HasRequired(d => d.Employee).WithMany(s => s.WorkTimes).Map(m => m.MapKey("Id").MapKey(new string[] { "EmployeeId" }));

        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}