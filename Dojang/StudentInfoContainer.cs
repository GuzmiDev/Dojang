using Business;
using Dojang.Utils;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dojang
{
    public partial class StudentInfoContainer : Form
    {
        private StudentEntity student;
        private LogStudentsEntity log;

        public StudentInfoContainer()
        {
            InitializeComponent();
            showStudent();
            
        }

        private Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        private void registerLog()
        {
            log = new LogStudentsEntity();

            log.Date = DateTime.Now;
            log.StudentID = student.StudentID;

            B_LogStudents.Save(log);
        }
        
        private void showStudent()
        {
                student = GetStudentByID.Student;
                var date = DateTime.Today;
                dateLabel.Text = date.ToString("d DE MMMM DEL yyyy", new CultureInfo("es-MX")).ToUpper();
                student.Belt = B_Belts.GetById(student.BeltID);
                imgPerfil.Image = ConvertByteArrayToImage(student.ImagePerfil);
                StudentName.Text = student.Name;
                pictureBox1.Image = ConvertByteArrayToImage(student.Belt.Image);

                var daysLefts = (student.CancelationDate - date).Days;
                var daysLeftsString = daysLefts.ToString();

                if (daysLefts <= 0)
                {
                    daysLeftsLabel.Text = "REQUIERE RENOVAR";
                    iconCorrect.Visible = false;
                    iconError.Visible = true;
                    btnRenew.Visible = true;
                }
                else if (daysLeftsString == "1")
                {
                    registerLog();
                    daysLeftsLabel.Text = daysLeftsString + " DIA";
                }
                else
                {
                    registerLog();
                    daysLeftsLabel.Text = daysLeftsString + " DIAS";

                }


        }

        private void updatePlan(PaymentPlanEntity plan)
        {
            switch (plan.Name)
            {
                case "SEMANAL":
                    student.CancelationDate = DateTime.Today.AddDays(plan.Days);
                    student.PaymentPlan = plan;
                    break;
                case "MENSUAL":
                    student.CancelationDate = DateTime.Today.AddDays(plan.Days);
                    student.PaymentPlan = plan;
                    break;
                default:
                    AlertBox.Error("Error al elegir plan");
                break;
            }
            try
            {
            var paymentHistory = new PaymentHistoryEntity();
                paymentHistory.Date = DateTime.Now;
                paymentHistory.StudentID = student.StudentID;
                paymentHistory.TypeOfTransaction = typeOfTransaction.Renovation;
                paymentHistory.PriceInTheMoment = plan.Price;
                paymentHistory.PaymentPlanInTheMoment = plan.Name;

                B_PaymentHistory.Save(paymentHistory);
            B_Students.Update(student);
            AlertBox.SimpleMessage("Renovación exitosa");

            }
            catch (Exception)
            {

                AlertBox.Error("Error al actualizar suscripcion");
            }

        }
        private void reloadPlan()
        {
            btnMonth.Visible = false;
            btnWeek.Visible = false;
            labelBetweenBtns.Visible = false;
            btnRenew.Visible=false;
            iconError.Visible = false;
            iconCorrect.Visible = true;
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            labelBetweenBtns.Visible = true;
            btnMonth.Visible = true;
            btnWeek.Visible = true;
            btnRenew.Visible = false;
        }

        private void btnWeek_Click(object sender, EventArgs e)
        {
            updatePlan(DojangForm.PaymentPlans.FirstOrDefault(plan => plan.Name == "SEMANAL"));
            reloadPlan();
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            updatePlan(DojangForm.PaymentPlans.FirstOrDefault(plan => plan.Name == "MENSUAL"));
            reloadPlan();

        }
    }
}
