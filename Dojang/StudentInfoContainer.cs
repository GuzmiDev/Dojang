using Business;
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
            student = B_Students.GetById(GetStudentByID.studentCode);

            if (student == null)
            {
                MessageBox.Show("No existe estudiante con este ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var date = DateTime.Today;
                dateLabel.Text = date.ToString("d DE MMMM DEL yyyy", new CultureInfo("es-MX")).ToUpper();
                student.Belt = B_Belts.GetById(student.BeltID);
                imgPerfil.Image = ConvertByteArrayToImage(student.ImagePerfil);
                StudentName.Text = student.Name;
                pictureBox1.Image = ConvertByteArrayToImage(student.Belt.Image);

                var daysLefts = (student.CancelationDate - date).Days.ToString();

                if (daysLefts == "0")
                {
                    daysLeftsLabel.Text = "REQUIERE RENOVAR";
                    iconCorrect.Visible = false;
                    iconError.Visible = true;
                    btnRenew.Visible = true;
                }
                else if (daysLefts == "1")
                {
                    registerLog();
                    daysLeftsLabel.Text = daysLefts + " DIA";
                }
                else
                {
                    registerLog();
                    daysLeftsLabel.Text = daysLefts + " DIAS";

                }


            }
        }
    }
}
