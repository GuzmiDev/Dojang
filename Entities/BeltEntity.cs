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
    public class BeltEntity
    {
        [Key]
        public int BeltID { get; set; }
        [Required]
        [StringLength(50)]
        public string BeltName { get; set; }
        [Required]
        public byte[] Image { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
