using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BreakTracking.Domain.Core;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BreakTracking.Domain.Models
{
    public class Department 
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        public string Name { get; set; }

        protected Department() { } // Empty constructor for EF
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
            
        }
    }
}
