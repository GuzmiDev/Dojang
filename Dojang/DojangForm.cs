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
    public partial class DojangForm : Form
    {
        private int[] btnColorsHover = { 57, 57, 75 };
        private int[] btnColorsLeave = { 35, 35, 44 };
        static public List<BeltEntity> Belts { get; set; }
        static public List<ScheduleEntity> Schedules{ get; set; }
        static public List<PaymentPlanEntity> PaymentPlans { get; set; }

        public DojangForm()
        {
            InitializeComponent();
            loadBelts();
            loadSchedules();
            loadPaymentPlans();
        }

        //Load DB
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
            Form fh = childForm as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            mainContainer.Controls.Add(fh);
            mainContainer.Tag = fh;
            fh.Show();
        }

        


        #region controls
        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GetStudentByID());
        }
        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(btnColorsHover[0], btnColorsHover[1], btnColorsHover[2]);
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(btnColorsLeave[0], btnColorsLeave[1], btnColorsLeave[2]);

        }

        private void btnRegisterStudent_MouseHover(object sender, EventArgs e)
        {
            btnRegisterStudent.BackColor = Color.FromArgb(btnColorsHover[0], btnColorsHover[1], btnColorsHover[2]);

        }

        private void btnRegisterStudent_MouseLeave(object sender, EventArgs e)
        {
            btnRegisterStudent.BackColor = Color.FromArgb(btnColorsLeave[0], btnColorsLeave[1], btnColorsLeave[2]);

        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            btnRegisterStudent.BackColor = Color.FromArgb(btnColorsHover[0], btnColorsHover[1], btnColorsHover[2]);

        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            btnRegisterStudent.BackColor = Color.FromArgb(btnColorsLeave[0], btnColorsLeave[1], btnColorsLeave[2]);

        }

        private void btnRegisterStudent_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StudentRegister());
        }
        #endregion

        private void DojangForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StudentList());
        }
    }
}
