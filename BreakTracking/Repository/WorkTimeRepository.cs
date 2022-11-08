using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BreakTracking.Context;
using BreakTracking.Domain.Models;

namespace BreakTracking.Repository
{
    public class WorkTimeRepository
    {
        private BreakTrackingContext _context;

        public WorkTimeRepository(BreakTrackingContext context) 
        {
            _context = context;
        }

        public void WorkTimeUpdate(WorkTime worktime) 
        {
            WorkTime result = _context.WorkTimes.Where(w => w.Id == worktime.Id).FirstOrDefault();

            if (result != null) 
            {
                result.StartTime = worktime.StartTime;
                result.EndTime = worktime.EndTime;
            }

            _context.SaveChanges();
        }
    }
}
