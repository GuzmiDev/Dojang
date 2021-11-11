using Business;

namespace Dojang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if(e.KeyChar == Convert.ToChar(Keys.Return))
            {
                _ShowData();
                IdGetter.Text = "";
                e.Handled = true;
            }

        }
        private Dictionary<string,string> _StudentData(string perfilId)
        {
            var student = B_Students.GetById(perfilId);

            if (student?.ImgUrl !=null && student?.Name != null )
            {
                student.Belt = B_Belts.GetById(student.BeltID);
                return new Dictionary<string, string>() { { "Nombre", student.Name }, { "ImgUrl", student.ImgUrl },  {"BeltImgUrl", student.Belt.ImageUrl } };   

            }else
            {
                throw new Exception("Error en la carga de la url de la imagen");
            }
        }
        private void _ShowData()
        {
            var id = IdGetter.Text;

            var data = _StudentData(id);

            StudentName.Text = data["Nombre"];
            ImgStudentPerfil.ImageLocation = data["ImgUrl"];
            Belt.ImageLocation = data["BeltImgUrl"];
        }

        private void ImgStudentPerfil_Click(object sender, EventArgs e)
        {

        }
    }
}