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
    public class PaymentHistoryEntity
    {
        [Key]
        public int PaymentID { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public typeOfTransaction TypeOfTransaction { get; set; }
        [Column(TypeName = "money")]
        public decimal PriceInTheMoment { get; set; }
        public string  PaymentPlanInTheMoment{ get; set; }


        //Relation with Student
        public string StudentID { get; set; }
        public StudentEntity Student { get; set; }
    }

    public enum typeOfTransaction
    {
        Suscription,
        Renovation,
        Prolongation,
    }
}
