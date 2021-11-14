using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
     public class LogStudentsEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Date{ get; set; }

        //Relation with student

        public string StudentID { get; set; }
        public StudentEntity Student { get; set; }
        public bool Status { get; set; }
    }
}
