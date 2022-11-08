using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BreakTracking.Domain.Models;
using BreakTracking.Context;

namespace BreakTracking.Application.Startup
{
    public class FirstLoading
    {
        private List<Department> Departments;
        private List<Shift> Shifts;
        private List<Employee> Employees;
        private List<WorkTime> WorkTimes;

        
        public FirstLoading() 
        {
            Departments = new List<Department>() {
                new Department(1,"Transport"),
                new Department(2,"Production"),
                new Department(3,"HR")
            };

            Shifts = new List<Shift>() {
                new Shift(1, "Day Shift"),
                new Shift(2, "Evening Shift"),
                new Shift(3, "Night Shift"),
                new Shift(4, "Weekend Shift")
            };

            Employees = new List<Employee> {
                new Employee(1,"James", 1, 3,true),
                new Employee(2,"Rebecca", 2, 2,false),
                new Employee(3,"Eoin", 1, 3,false),
                new Employee(4,"Patricia", 2, 1,true),
                new Employee(5,"Paul", 2, 1,false),
                new Employee(6,"Ross", 2, 2,false),
                new Employee(7,"Jhon", 3, 1,false),
                new Employee(8,"Alice", 3, 1,true),
                new Employee(9,"Clare", 3, 1,false),
                new Employee(10,"Bob", 2, 1,false),
                new Employee(11,"Jhonny", 3, 1,false),
            };

            WorkTimes = new List<WorkTime> {
            #region James
                    new WorkTime(1, 1, new DateTime(2022, 11, 01, 23, 00, 00), new DateTime(2022, 11, 02, 06, 00, 00)),
                    new WorkTime(2, 1, new DateTime(2022, 11, 02, 23, 00, 00), new DateTime(2022, 11, 03, 06, 00, 00)),
                    new WorkTime(3, 1, new DateTime(2022, 11, 03, 22, 00, 00), new DateTime(2022, 11, 04, 05, 00, 00)),
                    new WorkTime(4, 1, new DateTime(2022, 11, 04, 23, 13, 00), new DateTime(2022, 11, 05, 05, 10, 00)),
                    new WorkTime(5, 1, new DateTime(2022, 11, 05, 22, 45, 00), new DateTime(2022, 11, 06, 06, 10, 00)),
                    
            #endregion

            #region Rebecca
                    new WorkTime(6, 2, new DateTime(2022, 11, 01, 14, 00, 00), new DateTime(2022, 11, 01, 22, 05, 00)),
                    new WorkTime(7, 2, new DateTime(2022, 11, 02, 13, 50, 00), new DateTime(2022, 11, 02, 22, 00, 00)),
                    new WorkTime(8, 2, new DateTime(2022, 11, 03, 14, 30, 00), new DateTime(2022, 11, 03, 22, 40, 00)),
                    new WorkTime(9, 2, new DateTime(2022, 11, 04, 14, 17, 00), new DateTime(2022, 11, 04, 22, 00, 00)),
                    new WorkTime(10,2, new DateTime(2022, 11, 05, 14, 05, 00), new DateTime(2022, 11, 05, 22, 00, 00)),
                    
            #endregion

             #region Eoin
                    new WorkTime(11, 3, new DateTime(2022, 11, 01, 22, 20, 00), new DateTime(2022, 11, 02, 06, 10, 00)),
                    new WorkTime(12, 3, new DateTime(2022, 11, 02, 22, 08, 00), new DateTime(2022, 11, 03, 06, 01, 00)),
                    new WorkTime(13, 3, new DateTime(2022, 11, 04, 22, 33, 00), new DateTime(2022, 11, 05, 05, 00, 00)),
                    new WorkTime(14, 3, new DateTime(2022, 11, 05, 21, 50, 00), new DateTime(2022, 11, 06, 06, 28, 00)),
                    
            #endregion

            #region Patricia
                    new WorkTime(15, 4, new DateTime(2022, 11, 01, 06, 00, 00), new DateTime(2022, 11, 01, 13, 15, 00)),
                    new WorkTime(16, 4, new DateTime(2022, 11, 02, 05, 51, 00), new DateTime(2022, 11, 02, 13, 07, 00)),
                    new WorkTime(17, 4, new DateTime(2022, 11, 03, 06, 30, 00), new DateTime(2022, 11, 03, 13, 20, 00)),
                    new WorkTime(18, 4, new DateTime(2022, 11, 04, 05, 47, 00), new DateTime(2022, 11, 04, 13, 00, 00)),
                    new WorkTime(19,4, new DateTime(2022, 11, 05, 06, 05, 00), new DateTime(2022, 11, 05, 13, 00, 00)),
                    
            #endregion

            #region Paul
                    new WorkTime(20, 5, new DateTime(2022, 11, 01, 06, 10, 00), new DateTime(2022, 11, 01, 13, 10, 00)),
                    new WorkTime(21, 5, new DateTime(2022, 11, 02, 05, 41, 00), new DateTime(2022, 11, 02, 13, 02, 00)),
                    new WorkTime(22, 5, new DateTime(2022, 11, 03, 06, 13, 00), new DateTime(2022, 11, 03, 13, 23, 00)),
                    new WorkTime(23, 5, new DateTime(2022, 11, 04, 05, 54, 00), new DateTime(2022, 11, 04, 13, 16, 00)),
                    new WorkTime(24,5, new DateTime(2022, 11, 05, 06, 07, 00), new DateTime(2022, 11, 05, 13, 00, 00)),
                    
            #endregion

            #region Ross
                    new WorkTime(25, 6, new DateTime(2022, 11, 01, 13, 16, 00), new DateTime(2022, 11, 01, 22, 05, 00)),
                    new WorkTime(26, 6, new DateTime(2022, 11, 02, 13, 08, 00), new DateTime(2022, 11, 02, 21, 00, 00)),
                    new WorkTime(27, 6, new DateTime(2022, 11, 03, 13, 03, 00), new DateTime(2022, 11, 03, 21, 41, 00)),
                    new WorkTime(28, 6, new DateTime(2022, 11, 04, 13, 27, 00), new DateTime(2022, 11, 04, 22, 28, 00)),
                    new WorkTime(29,6, new DateTime(2022, 11, 05, 13, 35, 00), new DateTime(2022, 11, 05, 21, 00, 00)),
                    
            #endregion
        };

        }
        public BreakTrackingContext DataLoading() 
        {
            this.CleanDBCache();

            BreakTrackingContext context = new BreakTrackingContext();

            context.Departments.AddRange(Departments);
            context.Shifts.AddRange(Shifts);
            context.SaveChanges();

            Employees.ForEach(f => { context.Employees.Add(f); context.SaveChanges(); });

            WorkTimes.ForEach(f => { context.WorkTimes.Add(f); context.SaveChanges(); });

            return context;
            
        }

        private void CleanDBCache() 
        {
            BreakTrackingContext context = new BreakTrackingContext();
            context.Database.Delete();
            context.SaveChanges();
            context.Dispose();
            
        }
    }
}
