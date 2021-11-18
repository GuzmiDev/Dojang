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
        private PaymentPlanEntity paymentPlanSelected;
        private List<StudentEntity> allStudents;
        private List<StudentEntity> activeStudents;
        private List<StudentEntity> inactiveStudents;
        private StudentEntity student;
        private int dayLefts;
        private int index;

        public StudentList()
        {
            InitializeComponent();
            loadStudents();
            loadGridStudentList(activeStudents);
            loadBelts(DojangForm.Belts);
            loadPaymentPlans(DojangForm.PaymentPlans);
            loadSchedules(DojangForm.Schedules);
            inputFilterStatus.SelectedIndex = 0;
        }


        //Load inputs from db
        private void loadStudents()
        {
            this.allStudents = B_Students.GetAll();

            this.activeStudents = allStudents.Where(student => student.Status == true).ToList();

            this.inactiveStudents = allStudents.Where(student => student.Status == false).ToList();

        }
        private void loadGridStudentList(List<StudentEntity> students)
        {
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

                this.student = allStudents.FirstOrDefault(student => student.StudentID == studentIDRow);

                this.dayLefts = (student.CancelationDate - DateTime.Now).Days;

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
            btnActiveStudent.Visible = false;
            btnRemoveStudent.Visible = false;
            btnProlong.Visible = false;
            btnRenew.Visible = false;
            btnUpdateStudent.Visible = false;
        }

        //RENEW
        private void renewSuscription(PaymentPlanEntity plan)
        {
            switch (plan.Name)
            {
                case "SEMANAL":
                    student.CancelationDate = DateTime.Today.AddDays(plan.Days);
                    student.PaymentPlan = paymentPlanSelected;
                    break;
                case "MENSUAL":
                    student.CancelationDate = DateTime.Today.AddDays(plan.Days);
                    student.PaymentPlan = paymentPlanSelected;
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
        //PROLNG
        private void prolongSusctiption(PaymentPlanEntity plan)
        {
            switch (plan.Name)
            {
                case "SEMANAL":
                    student.CancelationDate = DateTime.Today.AddDays(this.dayLefts +plan.Days);
                    student.PaymentPlan = paymentPlanSelected;
                    break;
                case "MENSUAL":
                    student.CancelationDate = DateTime.Today.AddDays(this.dayLefts + plan.Days);
                    student.PaymentPlan = paymentPlanSelected;
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
                paymentHistory.TypeOfTransaction = typeOfTransaction.Prolongation;
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
        //Remove student
        private void removeStudent(string studentID)
        {
            try
            {
            B_Students.Delete(studentID);
            AlertBox.SimpleMessage("Estudiante eliminado");

            }
            catch (Exception)
            {
                AlertBox.Error("Error al eliminar estudiante");
            }
        }
        //status student
        private void activeStudent()
        {
            try
            {
                student.Status = true;
                B_Students.Update(student);
                AlertBox.SimpleMessage("Estudiante activado");

            }
            catch (Exception)
            {
                AlertBox.Error("Error al activar estudiante");
            }
        }
        
        //filters
        private void filterStatus()
        {
            loadStudents();
            switch (inputFilterStatus.SelectedItem.ToString())
            {
                case "TODOS":
                    ClearInputs();
                    dataGridStudents.Rows.Clear();
                    loadGridStudentList(allStudents);
                    break;
                case "ACTIVOS":
                    ClearInputs();
                    dataGridStudents.Rows.Clear();
                    loadGridStudentList(activeStudents);
                    break;
                case "INACTIVOS":
                    ClearInputs();
                    dataGridStudents.Rows.Clear();
                    loadGridStudentList(inactiveStudents);
                    break;
                default:
                    AlertBox.Error("Selecciona un filtro!");
                    break;
            }
        }

        //Controls
        private void dataGridStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fillInputsFromStudent(e);
            btnUpdateStudent.Visible = true;
            btnRenew.Visible = true;
            if (student.Status)
            {
            btnRemoveStudent.Visible = true;
            btnActiveStudent.Visible = false;

            }
            else
            {
                btnActiveStudent.Visible = true;
                btnRemoveStudent.Visible = false;
            }
            

            if(dayLefts > 0)
            {
            btnProlong.Visible = true;
            }
            else
            {
                btnProlong.Visible = false;
            }
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
            filterStatus();
            //ClearInputs();
            //dataGridStudents.Rows.Clear();
            //loadGridStudentList();
        }
        private void btnRenew_Click(object sender, EventArgs e)
        {
            renewSuscription(DojangForm.PaymentPlans.ElementAt(inputPlanStudentList.SelectedIndex));
            filterStatus();
            //dataGridStudents.Rows.Clear();
            //loadGridStudentList();
        }
        private void btnProlong_Click(object sender, EventArgs e)
        {
            prolongSusctiption(DojangForm.PaymentPlans.ElementAt(inputPlanStudentList.SelectedIndex));
            filterStatus();
            //dataGridStudents.Rows.Clear();
            //loadGridStudentList();
        }

        private void inputPlanStudentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(inputPlanStudentList.SelectedIndex > 0)
                this.paymentPlanSelected = DojangForm.PaymentPlans.ElementAt(inputPlanStudentList.SelectedIndex);
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            removeStudent(student.StudentID);
            filterStatus();
            //dataGridStudents.Rows.Clear();
            //loadGridStudentList();
        }

        private void inputFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterStatus();
        }

        private void btnActiveStudent_Click(object sender, EventArgs e)
        {
            activeStudent();
            filterStatus();

        }
    }
}
