using Business;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dojang
{
    public partial class Payments : Form
    {
        private List<PaymentHistoryEntity> payments;
        public Payments()
        {
            InitializeComponent();
            var fechaHoy = DateTime.Today;
            loadGridStudentList(fechaHoy.Year, fechaHoy.Month);
            generateTotalPrice();
        }
        private void loadGridStudentList(int year, int month)
        {
            this.payments = B_PaymentHistory.GetAll().Where(payment => payment.Date.Month == month && payment.Date.Year == year).ToList();


            foreach (var payment in payments)
            {
                int n = dataGridPayments.Rows.Add();
                payment.Student = B_Students.GetById(payment.StudentID);

                dataGridPayments.Rows[n].Cells[0].Value = payment.PaymentID;
                dataGridPayments.Rows[n].Cells[1].Value = payment.Student.Name + " " + payment.Student.LastName;
                dataGridPayments.Rows[n].Cells[2].Value = payment.PaymentPlanInTheMoment;

                if(payment.TypeOfTransaction == typeOfTransaction.Suscription)
                {
                    dataGridPayments.Rows[n].Cells[3].Value = "Suscripción";

                }else if (payment.TypeOfTransaction == typeOfTransaction.Prolongation)
                {
                    dataGridPayments.Rows[n].Cells[3].Value = "Prolongación";

                }
                else if (payment.TypeOfTransaction == typeOfTransaction.Renovation)
                {
                    dataGridPayments.Rows[n].Cells[3].Value = "Renovación";
                }


                dataGridPayments.Rows[n].Cells[4].Value = payment.Date;
                dataGridPayments.Rows[n].Cells[5].Value = "$" + Math.Round(payment.PriceInTheMoment, 2).ToString();
            }
        }

        private void generateTotalPrice()
        {

            var total = payments.Sum(payment => payment.PriceInTheMoment);

            labelTotalPrice.Text = "$" + Math.Round(total, 2).ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var month = dateTimePicker1.Value.Month;
            var year = dateTimePicker1.Value.Year;
            dataGridPayments.Rows.Clear();
            loadGridStudentList(year, month);
            generateTotalPrice();

        }

        private void Payments_Load(object sender, EventArgs e)
        {

        }
    }
}
