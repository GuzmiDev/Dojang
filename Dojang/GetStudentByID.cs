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
    public partial class GetStudentByID : Form
    {
        static public string studentCode { get; set; }
        public GetStudentByID()
        {
            InitializeComponent();
        }

        private void inputCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                studentCode = inputCode.Text;
                OpenChildForm(new StudentInfoContainer());
                inputCode.Text = "";
                
                e.Handled = true;
            }
        }

        private void OpenChildForm(object childForm)
        {
            if (containerPanel.Controls.Count > 1)
                containerPanel.Controls.RemoveAt(1);
            Form fh = childForm as Form;
            fh.TopLevel = false;
            fh.Location = new Point(87, 83);
            containerPanel.Controls.Add(fh);
            containerPanel.Tag = fh;
            fh.Show();
        }


        private void containerPanel_ControlRemoved(object sender, ControlEventArgs e)
        {


        }
    }
}
