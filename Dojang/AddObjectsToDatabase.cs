using Business;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dojang
{
    public partial class AddObjectsToDatabase : Form
    {
        public AddObjectsToDatabase()
        {
            InitializeComponent();
        }

        private void btnUploadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Title = "Open Image file";
            fileOpen.Filter = "Image Files (*.png)| *.png";
            if (fileOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Image =  Image.FromFile(fileOpen.FileName);
            }
        }

        private byte[] ConvertImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void btnSaveToDataBase_Click(object sender, EventArgs e)
        {
            var belt = new BeltEntity();

            belt.BeltName = inputNameBelt.Text;
            belt.Image = ConvertImageToBytes(pictureBox1.Image);

            B_Belts.Save(belt);

            MessageBox.Show("Cinturon Guardado");
        }
    }
}
