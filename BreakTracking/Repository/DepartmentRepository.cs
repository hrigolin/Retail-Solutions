using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BreakTracking.Context;
using BreakTracking.Domain.Models;

namespace BreakTracking.Repository
{
    public class DepartmentRepository : IDepartmentRepository, IDisposable
    {
        private BreakTrackingContext _context;
        
        public DepartmentRepository(BreakTrackingContext context) 
        {
            _context = context;
            
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
