using Business;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            var students = B_Students.GetAll();
            foreach (var student in students)
            {
            int n = tablaDatos.Rows.Add();

            tablaDatos.Rows[n].Cells[0].Value = student.StudentID;
            tablaDatos.Rows[n].Cells[1].Value = student.Name;
            tablaDatos.Rows[n].Cells[2].Value = student.CancelationDate;
            tablaDatos.Rows[n].Cells[3].Value = ConvertByteArrayToImage(student.ImagePerfil);
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
