using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakTracking.Aplication.ViewModel
{
    public class WeeklyWorkTimeViewModelcs
    {
        public Dictionary<String, DaylyWorkTime> WeeklyWorkTimeValue = new Dictionary<string, DaylyWorkTime>();

        public  WeeklyWorkTimeViewModelcs() 
        {
            WeeklyWorkTimeValue.Add("Mo", new DaylyWorkTime());
            WeeklyWorkTimeValue.Add("Tu", new DaylyWorkTime());
            WeeklyWorkTimeValue.Add("We", new DaylyWorkTime());
            WeeklyWorkTimeValue.Add("Th", new DaylyWorkTime());
            WeeklyWorkTimeValue.Add("Fr", new DaylyWorkTime());
            WeeklyWorkTimeValue.Add("Sa", new DaylyWorkTime());
            WeeklyWorkTimeValue.Add("Su", new DaylyWorkTime());
        }
    }

    public class DaylyWorkTime 
    {
        public DateTime ?StartTime { get; set; }
        public DateTime ?EndTime { get; set; }

        public TimeSpan ?TotalDayTimeOfWork { get; set; }

        public TimeSpan ?TotalDayBreakTime { get; set; }
    }
}
