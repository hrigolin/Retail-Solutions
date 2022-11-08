using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BreakTracking.Domain.Models;
using BreakTracking.Context;
using BreakTracking.Repository;
using BreakTracking.Aplication.ViewModel;
using BreakTracking.Aplication.Utilities;


namespace BreakTracking.Aplication
{
    public class SetWeeklyGrid
    {
        private UnitOfWork uow;
        BreakTrackingContext _context;
        TimeSpan totalWeekWorkTime = new TimeSpan();
        TimeSpan totalWeekBreakTime = new TimeSpan();

        List<WorkTime> workTimes = new List<WorkTime>();
        Employee employee;
        
        int empId = 0;

        public SetWeeklyGrid(BreakTrackingContext context, int employeeId ) 
        {
            _context = context;
            empId = employeeId;
            uow = new UnitOfWork(_context);

            

        }

        public Dictionary<String, DaylyWorkTime> getWeeklyWorkTime(int weekOfWork) 
        {

            DateTime firstDayofWeek = WeekUtilities.FirstDateOfWeek(DateTime.Now.Year, weekOfWork);
            DateTime lastDayofWeek = firstDayofWeek.AddDays(6);

            employee = uow.EmployeeRepository.GetByID(empId);

            workTimes = uow.WorkTimeRepository.Get(w => w.EmployeeId == empId && w.StartTime >= firstDayofWeek && w.StartTime <=lastDayofWeek).ToList();

            Dictionary<String, DaylyWorkTime> WeeklyWorkTimeValue = new WeeklyWorkTimeViewModelcs().WeeklyWorkTimeValue;

            foreach (var workt in workTimes)
            {

                TimeSpan totalBreakTime = new TimeSpan();

                TimeSpan totalWorkTime = workt.EndTime.Subtract(workt.StartTime);

                totalWeekWorkTime = totalWeekWorkTime.Add(totalWorkTime);

                var week = workt.StartTime.Date.DayOfWeek.ToString().Substring(0, 2);

                var dayRow = WeeklyWorkTimeValue[week];

                dayRow.StartTime = workt.StartTime;
                dayRow.EndTime = workt.EndTime;
                dayRow.TotalDayTimeOfWork = totalWorkTime;

                //Apply Break time for worked hours.
                totalBreakTime = employee.isManager ? new TimeSpan(0, (totalWorkTime.Hours * 15), 0) : new TimeSpan(0, (totalWorkTime.Hours * 10), 0);

                //Apply Break time for the hours . Shift Id 3 = Nigthshift
                totalBreakTime = totalBreakTime.Add(new TimeSpan(0, (employee.Shift.Id == 3 ? (totalWorkTime.Hours / 2) * 10 : (totalWorkTime.Hours / 4) * 10), 0));

                dayRow.TotalDayBreakTime = totalBreakTime;

                //totalWeekBreakTime = totalWeekBreakTime.Add(totalBreakTime);

            }

            return WeeklyWorkTimeValue;
        }
        
    }
}
