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
        private List<StudentEntity> filterStudents;
        private StudentEntity student;

        private int dayLefts;
        private int index;
        public StudentList()
        {
            InitializeComponent();
            loadGridStudentList(DojangForm.activeStudents);
            loadBelts(DojangForm.Belts);
            loadPaymentPlans(DojangForm.PaymentPlans);
            loadSchedules(DojangForm.Schedules);
            inputFilterStatus.SelectedIndex = 0;
        }


        //Load inputs from db
        
        private void loadGridStudentList(List<StudentEntity> students)
        {
                foreach (var student in students)
                {
                    int n = dataGridStudents.Rows.Add();
                    student.Belt = DojangForm.Belts.FirstOrDefault(belt => belt.BeltID == student.BeltID);
                    student.Schedule = DojangForm.Schedules.FirstOrDefault(schedule => schedule.ScheduleID == student.ScheduleID);
                    student.PaymentPlan = DojangForm.PaymentPlans.FirstOrDefault(plan => plan.PaymentPlanID == student.PaymentPlanID);

                    dataGridStudents.Rows[n].Cells[0].Value = student.StudentID;
                    dataGridStudents.Rows[n].Cells[1].Value = student.Name;
                    dataGridStudents.Rows[n].Cells[2].Value = student.LastName;
                    dataGridStudents.Rows[n].Cells[3].Value = student.Belt.BeltName;
                    dataGridStudents.Rows[n].Cells[4].Value = student.Schedule is null ? "Horario Sin Asignar" : student.Schedule.Schedule ;
                    dataGridStudents.Rows[n].Cells[5].Value = student.Age;

                    if(student.Gender == Gender.MALE)
                    {
                        dataGridStudents.Rows[n].Cells[6].Value = "Hombre";
                    }
                    else
                    {
                         dataGridStudents.Rows[n].Cells[6].Value = "Mujer";
                    }


                    dataGridStudents.Rows[n].Cells[7].Value = student.PaymentPlan.Name;
                    dataGridStudents.Rows[n].Cells[8].Value = student.Phone;
                    dataGridStudents.Rows[n].Cells[9].Value = student.CancelationDate;

                    if (student.Suscription)
                    {
                        dataGridStudents.Rows[n].Cells[10].Value = "Activa";
                    }
                    else
                    {
                        dataGridStudents.Rows[n].Cells[10].Value = "Inactiva";

                    }

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
            if (chechInputs())
            {
                AlertBox.Error("Complete el formulario porfavor");
            }
            else
            {
                student.Name = inputNameStudentList.Text.ToTitleCase();
                student.LastName = inputLastNameStudentList.Text.ToTitleCase();
                student.Phone = inputPhoneStudentList.Text;
                student.Age = Int32.Parse(inputAge.Text);

                if (radioFemale.Checked)
                {
                    student.Gender = Gender.FEMALE;
                }
                else
                {
                    student.Gender = Gender.MALE;
                }


                student.BeltID = inputBeltStudentList.SelectedIndex + 1;
                student.Belt = DojangForm.Belts.ElementAt(student.BeltID - 1);

                student.PaymentPlanID = inputPlanStudentList.SelectedIndex + 1;
                student.PaymentPlan = DojangForm.PaymentPlans.ElementAt(student.PaymentPlanID - 1);

                student.ScheduleID = inputScheduleStudentList.SelectedIndex + 1;
                student.Schedule = DojangForm.Schedules.ElementAt(student.ScheduleID - 1);



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
            
        }

        private bool chechInputs()
        {
            if (inputNameStudentList.Text == "" || inputLastNameStudentList.Text == "" || inputPhoneStudentList.Text == "" || inputBeltStudentList.Text == "" || inputPlanStudentList.Text == "" || inputScheduleStudentList.Text == "" || inputAge.Text == "")
            {
                return true;
            }
            else
            {
                return false;
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

                this.student = DojangForm.allStudents.FirstOrDefault(student => student.StudentID == studentIDRow);

                this.dayLefts = (student.CancelationDate - DateTime.Now).Days;

                inputNameStudentList.Text = student.Name;
                inputLastNameStudentList.Text = student.LastName;
                inputPhoneStudentList.Text = student.Phone;
                inputAge.Text = student.Age.ToString();

                if(student.Gender == Gender.MALE)
                {
                    radioMale.Checked = true;
                }
                else
                {
                    radioFemale.Checked = true;
                }

                inputBeltStudentList.SelectedIndex = student.BeltID - 1;

                if (student.Schedule == null)
                {
                    inputScheduleStudentList.SelectedIndex = -1;
                }
                else
                {
                inputScheduleStudentList.Text = student.Schedule.Schedule ;
                }

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
            inputAge.Text = "";
            inputBeltStudentList.SelectedIndex = -1;
            inputScheduleStudentList.SelectedIndex = -1;
            inputPlanStudentList.SelectedIndex = -1;
            radioFemale.Checked = false;
            radioMale.Checked = false;

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
            DojangForm.loadStudents();
            DojangForm.checkSuscriptionOfStudents();
            switch (inputFilterStatus.SelectedItem.ToString())
            {
                case "TODOS":
                    ClearInputs();
                    dataGridStudents.Rows.Clear();
                    loadGridStudentList(DojangForm.allStudents);
                    break;
                case "ACTIVOS":
                    ClearInputs();
                    dataGridStudents.Rows.Clear();
                    loadGridStudentList(DojangForm.activeStudents);
                    break;
                case "INACTIVOS":
                    ClearInputs();
                    dataGridStudents.Rows.Clear();
                    loadGridStudentList(DojangForm.inactiveStudents);
                    break;
                default:
                    AlertBox.Error("Selecciona un filtro!");
                    break;
            }
        }

        private List<StudentEntity> searchStudentWithName(string name)
        {
            return DojangForm.allStudents.Where(student => student.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();


        }
        private List<StudentEntity> searchStudentComplete(string name, string lastName)
        {
            return DojangForm.allStudents.Where(student => student.Name.Contains(name, StringComparison.OrdinalIgnoreCase) && student.LastName.Contains(lastName, StringComparison.OrdinalIgnoreCase)).ToList();

        }
        private List<StudentEntity> searchStudentWithLastName(string lastName)
        {
            return DojangForm.allStudents.Where(student => student.LastName.Contains(lastName, StringComparison.OrdinalIgnoreCase)).ToList();

        }

        //Controls
        private void dataGridStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fillInputsFromStudent(e);
            btnUpdateStudent.Visible = true;
            btnRenew.Visible = true;
            if(student != null)
            {
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


                if (dayLefts > 0)
                {
                    btnProlong.Visible = true;
                }
                else
                {
                    btnProlong.Visible = false;
                }
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
        }
        private void btnRenew_Click(object sender, EventArgs e)
        {
            renewSuscription(DojangForm.PaymentPlans.ElementAt(inputPlanStudentList.SelectedIndex));
            filterStatus();
        }
        private void btnProlong_Click(object sender, EventArgs e)
        {
            prolongSusctiption(DojangForm.PaymentPlans.ElementAt(inputPlanStudentList.SelectedIndex));
            filterStatus();
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
        private void inputPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(inputFilterName.Text.Length > 0 && inputFilterLastName.Text.Length > 0)
            {
                filterStudents = searchStudentComplete(inputFilterName.Text, inputFilterLastName.Text);
            }else if(inputFilterName.Text.Length > 0)
            {
                filterStudents = searchStudentWithName(inputFilterName.Text);
            }else if(inputFilterLastName.Text.Length > 0)
            {
                filterStudents = searchStudentWithLastName(inputFilterLastName.Text);
            }
            else
            {
                AlertBox.Error("Rellene algún filtro primero");
                return;
            }
            ClearInputs();
            dataGridStudents.Rows.Clear();
            loadGridStudentList(filterStudents);
        }
    }
}
