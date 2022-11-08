using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BreakTracking.Application.ViewModel;
using BreakTracking.Domain.Models;

namespace BreakTracking.Repository
{
    public interface IEmployeeRepository : IDisposable
    {
        IEnumerable<EmployeeGridViewModel> GetEmployeeGridViewModel(Expression<Func<Employee, bool>> filter = null);
    }
       
}
