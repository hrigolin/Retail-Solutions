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
    public class Shift
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }
        public string Name { get; set; }


        protected Shift() { } // Empty constructor for EF
        public Shift(int id, string name)
        {
            Id = id;
            Name = name;

        }
    }
}
