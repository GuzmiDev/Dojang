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
    public class SuscriptionEntity
    {
        [Key]
        public int SuscriptionID { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }
        [Required]
        public bool Status { get; set; } 

        //Relation with Student
        public string StudentID { get; set; }
        public StudentEntity Student { get; set; }
    }
}
