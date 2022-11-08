using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BreakTracking.Context;
using BreakTracking.Domain.Models;
using BreakTracking.Aplication.ViewModel;

namespace BreakTracking.Repository
{
    public class EmployeeRepository : IDisposable, IEmployeeRepository
    {
        private BreakTrackingContext _context;

        public EmployeeRepository(BreakTrackingContext context)
        {
            _context = context;

        }

        public IEnumerable<EmployeeGridViewModel> GetEmployeeGridViewModel(Expression<Func<Employee, bool>> filter = null)
        {
            List<EmployeeGridViewModel> employeeGridViewModel = new List<EmployeeGridViewModel>();

           
            if (filter != null)
            {
                var result = _context.Employees.Where(filter).Join(_context.Departments, e => e.DepartmentId, d => d.Id, (e, d) => new { Id = e.Id, Name = e.Name, Department = d.Name, Shift = e.ShiftId })
                                                .Join(_context.Shifts, e => e.Shift, s => s.Id, (e, s) => new { Id = e.Id, Name = e.Name, Department = e.Department, Shift = s.Name }).ToList();

                result.ForEach(f =>
                {
                    employeeGridViewModel.Add(new EmployeeGridViewModel() { EmployeeId = f.Id, EmployeeName = f.Name, DepartmentName = f.Department, ShiftName = f.Shift });
                });
            }
            else {
                 var result = _context.Employees.Join(_context.Departments, e => e.DepartmentId, d => d.Id, (e, d) => new { Id = e.Id, Name = e.Name, Department = d.Name, Shift = e.ShiftId })
                                                    .Join(_context.Shifts, e => e.Shift, s => s.Id, (e, s) => new { Id = e.Id, Name = e.Name, Department = e.Department, Shift = s.Name }).ToList();

                result.ForEach(f =>
                {
                    employeeGridViewModel.Add(new EmployeeGridViewModel() { EmployeeId = f.Id, EmployeeName = f.Name, DepartmentName = f.Department, ShiftName = f.Shift });
                });
            }



            return employeeGridViewModel;

        }
     

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
