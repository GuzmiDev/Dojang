using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ScheduleEntity
    {
        [Key]
        public int ScheduleID { get; set; }
        [Required]
        public string Schedule { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
