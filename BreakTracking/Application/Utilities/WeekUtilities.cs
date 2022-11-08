using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakTracking.Application.Utilities
{

    public static class WeekUtilities
    {
       
        public static List<int> GetAllWeekNumberOfYear(int year)
        {
            List<int> weekLst = new List<int>();
            var LastDayWeek = GetWeekOfYear(new DateTime(year, 12, 31));

            for (int week = 1; week <= LastDayWeek; week++)
            {
                weekLst.Add(week);
            }

            return weekLst;
        }

        public static int GetWeekOfYear(DateTime date)
        {
            CultureInfo ciCurr = System.Globalization.CultureInfo.CurrentCulture;

            var week = ciCurr.Calendar.GetWeekOfYear(date,
             CalendarWeekRule.FirstFourDayWeek,
             DayOfWeek.Monday);

            return week;
        }
        public static DateTime FirstDateOfWeek(int year, int weekOfYear)
        {
            DateTime jan1 = new DateTime(year, 1, 1);
            int daysOffset = DayOfWeek.Thursday - jan1.DayOfWeek;

            DateTime firstThursday = jan1.AddDays(daysOffset);
            var cal = CultureInfo.CurrentCulture.Calendar;
            int firstWeek = cal.GetWeekOfYear(firstThursday, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            var weekNum = weekOfYear;
            if (firstWeek == 1)
            {
                weekNum -= 1;
            }

            var result = firstThursday.AddDays(weekNum * 7);

            return result.AddDays(-3);
        }
    }
}
