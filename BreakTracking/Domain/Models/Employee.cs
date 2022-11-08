using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BreakTracking.Domain.Core;
using BreakTracking.Domain.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BreakTracking.Domain.Models
{
    public class Employee
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        public string Name { get; set; }

        [Key]
        [Column(Order = 1)]
        [ForeignKey("Department")]
        public int DepartmentId { get; private set; }

        [Key]
        [Column(Order = 2)]
        [ForeignKey("Shift")]
        public int ShiftId { get; private set; }
        public bool isManager { get; private set; }

        public virtual ICollection<WorkTime> WorkTimes { get; private set; }

        public virtual Department Department { get; set; }
        public virtual Shift Shift { get; set; }

        protected Employee() { } // Empty constructor for EF
        public Employee(int id, string name, int departmentId, int shiftId, bool ismanager)
        {
            Id = id;
            Name = name;
            DepartmentId = departmentId;
            ShiftId = shiftId;
            isManager = ismanager;

        }
    }
}
