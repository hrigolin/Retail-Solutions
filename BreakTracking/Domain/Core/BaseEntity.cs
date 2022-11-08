using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BreakTracking.Domain.Core
{
    public abstract class BaseEntity
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }
    }
}