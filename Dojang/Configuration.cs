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
    public partial class Configuration : Form
    {
        private PaymentPlanEntity planSelected;

        public Configuration()
        {
            InitializeComponent();
            loadPaymentPlans(DojangForm.PaymentPlans);
            loadSchedules(DojangForm.Schedules);
        }

        private void loadPaymentPlans(List<PaymentPlanEntity> paymentPlans)
        {
            foreach (var paymentPlan in paymentPlans)
            {
                inputBoxPlans.Items.Add(paymentPlan.Name);
            }
        }
        private void loadSchedules(List<ScheduleEntity> scheduleEntities)
        {
            foreach (var schedule in scheduleEntities)
            {
                inputSchedules.Items.Add(schedule.Schedule);
            }
        }

        private void loadTextInputPricePlan()
        {
            this.planSelected = DojangForm.PaymentPlans.FirstOrDefault(plan => plan.Name == inputBoxPlans.SelectedItem.ToString());

            inputPricePlan.Text = planSelected.Price.ToString();
            checkInputPlansIsNotNull();
            
        }
        private void checkInputPlansIsNotNull()
        {
            if (inputPricePlan.Text == "" || inputBoxPlans.SelectedIndex == -1)
            {
                btnSavePrice.Enabled = false;
            }
            else
            {
                btnSavePrice.Enabled = true;
            }
        }
        private void checkInputDaysIsNotNull()
        {
            if(inputAddDays.Text == "")
            {
                btnAddDays.Enabled = false;
            }
            else
            {
                btnAddDays.Enabled= true;
            }
        }
        private void updatePrice()
        {
            this.planSelected.Price = Int32.Parse(inputPricePlan.Text);


            try
            {
                B_PaymentPlan.Update(this.planSelected);
                AlertBox.SimpleMessage("Precio guardado correctamente");
            }
            catch (Exception)
            {
                AlertBox.Error("Error en la base de datos al actualizar precio");
            }
        }
        private void addDaysToStudents()
        {
            var days = Int32.Parse(inputAddDays.Text);
            var students = B_Students.GetAll().Where(student => student.Status);
            foreach (var student in students)
            {
                student.CancelationDate = student.CancelationDate.AddDays(days);
                B_Students.Update(student);
            }
            AlertBox.SimpleMessage("Se añadieron correctamente!");
        }


        private void inputBoxPlans_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTextInputPricePlan();
        }

        private void btnSavePrice_Click(object sender, EventArgs e)
        {
            updatePrice();
        }

        private void inputPricePlan_TextChanged(object sender, EventArgs e)
        {
            checkInputPlansIsNotNull();
        }

        private void inputAddDays_TextChanged(object sender, EventArgs e)
        {
            checkInputDaysIsNotNull();
        }


        private void btnAddDays_Click(object sender, EventArgs e)
        {
            addDaysToStudents();
        }

        private void inputPricePlan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
