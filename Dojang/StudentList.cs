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
    public partial class StudentList : Form
    {
        private BeltEntity belt;
        private ScheduleEntity schedule;
        private PaymentPlanEntity paymentPlan;
        private List<StudentEntity> students;
        private StudentEntity student;

        public StudentList()
        {
            InitializeComponent();
            loadGridStudentList();
            loadBelts(DojangForm.Belts);
            loadPaymentPlans(DojangForm.PaymentPlans);
            loadSchedules(DojangForm.Schedules);
        }


        //Load inputs from db
        private void loadGridStudentList()
        {
            students = B_Students.GetAll();
            foreach (var student in students)
            {
                int n = dataGridStudents.Rows.Add();
                student.Belt = DojangForm.Belts[student.BeltID - 1];
                student.Schedule = DojangForm.Schedules[student.ScheduleID - 1];
                student.PaymentPlan = DojangForm.PaymentPlans[student.PaymentPlanID - 1];

                dataGridStudents.Rows[n].Cells[0].Value = student.StudentID;
                dataGridStudents.Rows[n].Cells[1].Value = student.Name;
                dataGridStudents.Rows[n].Cells[2].Value = student.LastName;
                dataGridStudents.Rows[n].Cells[3].Value = student.Belt.BeltName;
                dataGridStudents.Rows[n].Cells[4].Value = student.Schedule.Schedule;
                dataGridStudents.Rows[n].Cells[5].Value = student.PaymentPlan.Name;
                dataGridStudents.Rows[n].Cells[6].Value = student.CancelationDate;

            }
        }
        private void loadBelts(List<BeltEntity> Belts)
        {
            foreach (var belt in Belts)
            {
                inputBeltStudentList.Items.Add(belt.BeltName);
            }
        }
        private void loadPaymentPlans(List<PaymentPlanEntity> paymentPlans)
        {
            foreach (var paymentPlan in paymentPlans)
            {
                inputPlanStudentList.Items.Add(paymentPlan.Name);
            }
        }
        private void loadSchedules(List<ScheduleEntity> schedules)
        {

            foreach (var Schedules in schedules)
            {
                inputScheduleStudentList.Items.Add(Schedules.Schedule);
            }
        }

        //ShowSelectedData
        private void fillInputsFromStudent()
        {

        }

        private void dataGridStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            try
            {
                int index = e.RowIndex;

                var selectedRow = dataGridStudents.Rows[index];

                this.belt = DojangForm.Belts.FirstOrDefault(b => b.BeltName == selectedRow.Cells[3].Value.ToString());
                this.schedule = DojangForm.Schedules.FirstOrDefault(b => b.Schedule == selectedRow.Cells[4].Value.ToString());
                this.paymentPlan = DojangForm.PaymentPlans.FirstOrDefault(b => b.Name == selectedRow.Cells[5].Value.ToString());

                var studentIDRow = selectedRow.Cells[0].Value.ToString();
                var studentIndex = Int32.Parse(studentIDRow);
                this.student = students.ElementAt(studentIndex-1);

                inputNameStudentList.Text = selectedRow.Cells[1].Value.ToString();
                inputLastNameStudentList.Text = selectedRow.Cells[2].Value.ToString();
                inputPhoneStudentList.Text = selectedRow.Cells[5].Value.ToString();
                inputBeltStudentList.SelectedIndex = belt.BeltID -1;
                inputScheduleStudentList.SelectedIndex = schedule.ScheduleID -1;
                inputPlanStudentList.SelectedIndex = paymentPlan.PaymentPlanID -1;
                imgPerfil.Image = ConvertByteArrayToImage(student.ImagePerfil);

            }
            catch (Exception)
            {

            }
        }
        private Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
