using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BreakTracking.Domain.Core;

namespace BreakTracking.Domain.Models
{
    public class WorkTime
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        //[Key]
        //[Column(Order = 1)]
        //[ForeignKey("Employee")]
        public int EmployeeId { get; private set; }

        public DateTime StartTime { get;  set; }
        public DateTime EndTime { get;  set; }

        public virtual Employee Employee { get; set; }
        protected WorkTime() { } // Empty constructor for EF
        public WorkTime(int id, int employeeId, DateTime startTime, DateTime endTime)
        {
            Id = id;
            EmployeeId = employeeId;
            StartTime = startTime;
            EndTime = endTime;

        }
    }
}
