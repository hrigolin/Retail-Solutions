using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BreakTracking.Context;
using BreakTracking.Domain.Models;


namespace BreakTracking.Repository
{
    public class UnitOfWork : IDisposable
    {
        private BreakTrackingContext _context;
        private GenericRepository<Department> departmentRepository;
        private GenericRepository<Employee> employeeRepository;
        private GenericRepository<Shift> shiftRepository;
        private GenericRepository<WorkTime> workTimeRepository;

        public UnitOfWork(BreakTrackingContext context) 
        {
            _context = context;
        }
        public GenericRepository<Department> DepartmentRepository
        {
            get
            {

                if (this.departmentRepository == null)
                {
                    this.departmentRepository = new GenericRepository<Department>(_context);
                }
                return departmentRepository;
            }
        }

        public GenericRepository<Employee> EmployeeRepository
        {
            get
            {

                if (this.employeeRepository == null)
                {
                    this.employeeRepository = new GenericRepository<Employee>(_context);
                }
                return employeeRepository;
            }
        }
        public GenericRepository<Shift> ShiftRepository
        {
            get
            {

                if (this.shiftRepository == null)
                {
                    this.shiftRepository = new GenericRepository<Shift>(_context);
                }
                return shiftRepository;
            }
        }
        public GenericRepository<WorkTime> WorkTimeRepository
        {
            get
            {

                if (this.workTimeRepository == null)
                {
                    this.workTimeRepository = new GenericRepository<WorkTime>(_context);
                }
                return workTimeRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
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
