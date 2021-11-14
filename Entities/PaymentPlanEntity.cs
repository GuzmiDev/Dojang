using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PaymentPlanEntity
    {
        [Key]
        public int PaymentPlanID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        [Required]
        public int Days { get; set; }
        public bool Status { get; set; }


    }
}
