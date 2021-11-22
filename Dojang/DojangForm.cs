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
    public partial class DojangForm : Form
    {
       private Form fh;
        static public List<StudentEntity> allStudents;
        static public List<StudentEntity> activeStudents;
        static public List<StudentEntity> inactiveStudents;
        static public List<BeltEntity> Belts { get; set; }
        static public List<ScheduleEntity> Schedules{ get; set; }
        static public List<PaymentPlanEntity> PaymentPlans { get; set; }

        public DojangForm()
        {
            InitializeComponent();
            loadStudents();
            checkSuscriptionOfStudents();
            loadBelts();
            loadSchedules();
            loadPaymentPlans();
        }

        //Load DB
        static public void loadStudents()
        {
            allStudents = B_Students.GetAll().Where(student => student.Status).ToList();
        }

        static public void checkSuscriptionOfStudents()
        {
            var date = DateTime.Today;
            foreach (var student in allStudents)
            {
                var daysLefts = (student.CancelationDate - date).Days;
                if (daysLefts <= 0)
                {
                    student.Suscription = false;
                    B_Students.Update(student);
                }
                else
                {
                    student.Suscription = true;
                    B_Students.Update(student);
                }

            }

            activeStudents = allStudents.Where(student => student.Suscription).ToList();
            inactiveStudents = allStudents.Where(student => !student.Suscription).ToList();

        }
        private void loadPaymentPlans()
        {
            PaymentPlans = B_PaymentPlan.GetAll();
        }

        private void loadSchedules()
        {
            Schedules = B_Schedule.GetAll();
        }

        private void loadBelts()
        {
            Belts = B_Belts.GetAll();
        }

        private void OpenChildForm(object childForm)
        {
            if (mainContainer.Controls.Count > 0)
                mainContainer.Controls.RemoveAt(0);
            fh = childForm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            mainContainer.Controls.Add(fh);
            mainContainer.Tag = fh;
            fh.Show();
        }

        private void ShowPanelClick(Panel panelToShow)
        {
            var paneles = new Panel[] { barBlueHome, barBlueRegisterStudent, barBlueStudents, barBluePayments, barBlueConfiguration };

            foreach (var panel in paneles)
            {
                if(panelToShow == panel)
                {
                    panel.Visible = true;
                }
                else
                {
                panel.Visible = false;
                }
            }
        }
        
        #region controls
        private void DojangForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
        private void mainContainer_ControlRemoved(object sender, ControlEventArgs e)
        {
            fh.Close();
         
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            ShowPanelClick(barBlueHome);
            OpenChildForm(new GetStudentByID());
        }
        private void btnRegisterStudent_Click(object sender, EventArgs e)
        {
            ShowPanelClick(barBlueRegisterStudent);
            OpenChildForm(new StudentRegister());
        }
        private void btnStudentList_Click(object sender, EventArgs e)
        {
            ShowPanelClick(barBlueStudents);
            OpenChildForm(new StudentList());
        }
        private void btnPayments_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Payments());
            ShowPanelClick(barBluePayments);
        }
        private void btnConfiguration_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Configuration());
            ShowPanelClick(barBlueConfiguration);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

    }
}
