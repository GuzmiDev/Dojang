using AForge.Video;
using AForge.Video.DirectShow;
using Business;
using Dojang.Utils;
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
    public partial class StudentRegister : Form
    {
        private bool HayDispositivos;
        private FilterInfoCollection MisDispositivos;
        private VideoCaptureDevice MiWebCam;
        private string studentName;
        private string studentNumber;
        private StudentEntity student;
        private PaymentHistoryEntity paymentHistory;
        private List<PaymentPlanEntity> paymentPlans;
        private PaymentPlanEntity paymentPlan;
        private int lastNumberStudent;
        public StudentRegister()
        {
            InitializeComponent();
            loadBelts(DojangForm.Belts);
            this.paymentPlans = DojangForm.PaymentPlans;
            loadPaymentPlans(paymentPlans);
            loadSchedules(DojangForm.Schedules);
            CargaDispositivos();
            loadLastNumber();
        }


        //Insert Data in ComboBox from DB
        private void loadBelts(List<BeltEntity> Belts)
        {
            foreach (var belt in Belts)
            {
                InputBelt.Items.Add(belt.BeltName);
            }
        }
        private void loadPaymentPlans(List<PaymentPlanEntity> paymentPlans)
        {
            foreach (var paymentPlan in paymentPlans)
            {
                inputPaymentPlan.Items.Add(paymentPlan.Name);
            }
        }
        private void loadSchedules(List<ScheduleEntity> schedules)
        {

            foreach (var Schedules in schedules)
            {
                inputSchedule.Items.Add(Schedules.Schedule);
            }
        }
        private void loadLastNumber()
        {
            lastNumberStudent = B_Students.GetAll().Count;
            this.studentNumber = (lastNumberStudent + 1).ToString();
        }

        //REGISTER STUDENT TO  DATABASE
        private void saveStudent()
        {
            student = new StudentEntity();
            student.StudentID = studentNumber;
            student.Name = inputName.Text.ToTitleCase();
            student.LastName = inputLastName.Text.ToTitleCase();
            student.Phone = inputPhone.Text;
            student.Age = Int32.Parse(inputAge.Text);
            student.Suscription = true;

            if (radioGenderMale.Checked)
            {
                student.Gender = Gender.MALE;
            }
            else
            {
                student.Gender = Gender.FEMALE;
            }


            if(inputPaymentPlan.SelectedIndex == 0)
            {

            student.CancelationDate = DateTime.Today.AddDays(7);
            }
            else
            {
                student.CancelationDate = DateTime.Today.AddDays(30);

            }



            student.ImagePerfil = ImageManipulator.ConvertImageToBytes(getOnlyPictureBoxPhoto());
            student.ImageBarCode = ImageManipulator.ConvertImageToBytes(getBarcodePanelImage());
            student.BeltID = InputBelt.SelectedIndex + 1;
            student.ScheduleID = inputSchedule.SelectedIndex + 1;
            student.PaymentPlanID = inputPaymentPlan.SelectedIndex + 1;


            try
            {
            B_Students.Save(student);
            MessageBox.Show("Estudiante guardado correctamente", "Base",MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la base de dato: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (inputName.Text == "" || InputBelt.Texts == "" || inputSchedule.Texts == "" || inputPaymentPlan.Texts == "" || inputAge.Text == "" || (radioGenderFemale.Checked == false && radioGenderMale.Checked == false))
            {
                MessageBox.Show("Rellene los campos obligarorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
            saveStudent();
            registerPayment();
            loadLastNumber();
            clearInputs();
            }
        }

        private void clearInputs()
        {
            inputName.Text = "";
            inputLastName.Text = "";
            inputPhone.Text = "";
            InputBelt.Texts = "";
            inputSchedule.Texts = "";
            inputPaymentPlan.Texts = "";
            inputAge.Text = "";
            radioGenderFemale.Checked = false;
            radioGenderMale.Checked = false;
            panelBarCode.BackgroundImage = null;


        }
        private void registerPayment()
        {
            paymentHistory  = new PaymentHistoryEntity();
            paymentHistory.Date = DateTime.Now;
            paymentHistory.TypeOfTransaction = typeOfTransaction.Suscription;
            paymentHistory.PaymentPlanInTheMoment = inputPaymentPlan.SelectedItem.ToString();

            this.paymentPlan = paymentPlans.ElementAt(inputPaymentPlan.SelectedIndex);
            paymentHistory.PriceInTheMoment = this.paymentPlan.Price;
            paymentHistory.StudentID = student.StudentID;

            B_PaymentHistory.Save(paymentHistory);
        }

        //Methods and Events for WEBCAM
        public void CargaDispositivos()
        {
            MisDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if(MisDispositivos.Count > 0)
            {
                HayDispositivos = true;
                for (int i = 0; i < MisDispositivos.Count; i++)
                    inputWebCam.Items.Add(MisDispositivos[i].Name.ToString());
                inputWebCam.Texts = "Elige un Dispositivo";
            }
            else
                HayDispositivos = false;
            
        }
        private void Capturando(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = Imagen;
        }

         private void CerrarWebCam()
        {
            if(MiWebCam !=null && MiWebCam.IsRunning)
            {
                MiWebCam.SignalToStop();
                MiWebCam = null;
            }
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            try
            {
                CerrarWebCam();
                int i = inputWebCam.SelectedIndex;
                string NombreVideo = MisDispositivos[i].MonikerString;
                MiWebCam = new VideoCaptureDevice(NombreVideo);
                MiWebCam.NewFrame += new NewFrameEventHandler(Capturando);
                MiWebCam.Start();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Elija un dispositivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnTakePicture_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox1.Image;
            CerrarWebCam();
        }

        //Events for BARCODE
        private void btnSaveBarCode_Click(object sender, EventArgs e)
        {
            BarCodeGenerator.SaveBarcode(panelContainerBarCode, nameStudentBarCode, studentNumber);
        }

        private void inputLastName_TextChanged(object sender, EventArgs e)
        {
            studentName =  inputName.Text + " " + inputLastName.Text;
            BarCodeGenerator.generateBarCode(panelBarCode, nameStudentBarCode, studentNumber, studentName);

        }

        private void inputName_TextChanged(object sender, EventArgs e)
        {
            studentName = inputName.Text + " " + inputLastName.Text;
            BarCodeGenerator.generateBarCode(panelBarCode, nameStudentBarCode, studentNumber, studentName);
        }
        private Bitmap getBarcodePanelImage()
        {
            int width = panelContainerBarCode.Size.Width;
            int height = panelContainerBarCode.Size.Height;

            Bitmap bm = new Bitmap(width, height);
            panelContainerBarCode.DrawToBitmap(bm, new Rectangle(0, 0, width, height));
            return bm;
        }

        private Bitmap getOnlyPictureBoxPhoto()
        {
            int width = pictureBox1.Size.Width;
            int height = pictureBox1.Size.Height;

            Bitmap bm = new Bitmap(width, height);
            pictureBox1.DrawToBitmap(bm, new Rectangle(0, 0, width, height));
            return bm;
        }


        private void inputPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void StudentRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            CerrarWebCam();
        }
    }
}
