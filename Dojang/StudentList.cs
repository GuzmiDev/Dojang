using Business;
using Dojang.Utils;
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
        private int index;

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
                    dataGridStudents.Rows[n].Cells[6].Value = student.Phone;
                    dataGridStudents.Rows[n].Cells[7].Value = student.CancelationDate;

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

        //Update Student
        private void UpdateStudent()
        {
            student.Name = inputNameStudentList.Text;
            student.LastName = inputLastNameStudentList.Text;
            student.Phone = inputPhoneStudentList.Text;

            student.BeltID = inputBeltStudentList.SelectedIndex + 1;
            student.Belt = DojangForm.Belts.ElementAt(student.BeltID - 1);

            student.ScheduleID = inputScheduleStudentList.SelectedIndex +1;
            student.Schedule = DojangForm.Schedules.ElementAt(student.ScheduleID - 1);

            student.PaymentPlanID = inputPlanStudentList.SelectedIndex + 1;
            student.PaymentPlan = DojangForm.PaymentPlans.ElementAt(student.PaymentPlanID - 1);


            if(student.PaymentPlanID != inputPlanStudentList.SelectedIndex + 1)
            {
                student.CancelationDate = student.CancelationDate.AddDays(30);
            }

            try
            {
            B_Students.Update(student);
                AlertBox.SimpleMessage("Estudiante acutalizado.");

            }
            catch (Exception)
            {
                AlertBox.Error("Error al actualizar estudiante en la base de datos.");
            }
        }

        //ShowSelectedData
        private void fillInputsFromStudent(DataGridViewCellEventArgs e)
        {
            try
            {
                this.index = e.RowIndex;

                var selectedRow = dataGridStudents.Rows[index];

              
                var studentIDRow = selectedRow.Cells[0].Value.ToString();
                var studentIndex = Int32.Parse(studentIDRow);
                this.student = students.ElementAt(studentIndex - 1);

                inputNameStudentList.Text = student.Name;
                inputLastNameStudentList.Text = student.LastName;
                inputPhoneStudentList.Text = student.Phone;
                inputBeltStudentList.SelectedIndex = student.BeltID - 1;
                inputScheduleStudentList.SelectedIndex = student.ScheduleID -1;
                inputPlanStudentList.SelectedIndex = student.PaymentPlanID - 1;
                imgPerfil.Image = ImageManipulator.ConvertByteArrayToImage(student.ImagePerfil);

            }
            catch (System.NullReferenceException)
            {

            }
            catch (Exception)
            {

            }
        }

        //Clear inputs
        private void ClearInputs()
        {
            inputNameStudentList.Text = "";
            inputLastNameStudentList.Text = "";
            inputPhoneStudentList.Text = "";
            inputBeltStudentList.SelectedIndex = -1;
            inputScheduleStudentList.SelectedIndex = -1;
            inputPlanStudentList.SelectedIndex = -1;
            imgPerfil.Image = null;
            panelBarCode.BackgroundImage = null;
        }

        //Controls
        private void dataGridStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fillInputsFromStudent(e);
            btnUpdateStudent.Visible = true;
        }

        private void btnSaveBarCode_Click(object sender, EventArgs e)
        {
            if (student != null)
            {

            BarCodeGenerator.SaveBarcode(panelContainerBarCode, nameStudentBarCode, student.StudentID);
            }
            else
            {
                AlertBox.Error("Seleccione un estudiante primero");
            }
        }

        private void inputNameStudentList_TextChanged(object sender, EventArgs e)
        {
            BarCodeGenerator.generateBarCode(panelBarCode, nameStudentBarCode, student.StudentID, inputNameStudentList.Text + " " + inputLastNameStudentList.Text);

        }

        private void inputLastNameStudentList_TextChanged(object sender, EventArgs e)
        {
            BarCodeGenerator.generateBarCode(panelBarCode, nameStudentBarCode, student.StudentID, inputNameStudentList.Text + " " + inputLastNameStudentList.Text);

        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            UpdateStudent();
            ClearInputs();
            dataGridStudents.Rows.Clear();
            loadGridStudentList();
        }
    }
}
