using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public  class StudentEntity
    {
        [Key]
        [StringLength(100)]
        public string StudentID { get; set; }
        public string Name { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public DateTime CancellationDate { get; set; }
        public bool Status { get; set; }
        [DisplayName("Image")]
        public byte[]? ImagePerfil { get; set; }
        [DisplayName("Image")]
        public byte[]? ImageBarCode { get; set; }

        //Relation with belts
        public int BeltID { get; set; }
        public BeltEntity Belt { get; set; }

        //Relation with Schedule
        public int ScheduleID { get; set; }
        public ScheduleEntity Schedule { get; set; }


    }
}
