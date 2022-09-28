using ServicioSocial.Forms.Clases;
using System.Runtime.InteropServices;

namespace ServicioSocial
{
    public partial class login : Form
    {
        Login ln = new Login();
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
     
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
          
        }

        private void pcView_Click(object sender, EventArgs e)
        {
            txtpass.PasswordChar = ' ';
        }

        private void pbIniciar_Click(object sender, EventArgs e)
        {
            if (txtuser.Text!="" && txtpass.Text!="")
            {
                Documentos.carnet = txtuser.Text;
                ln.Logeo(txtuser.Text, txtpass.Text);
            }
            else if(txtuser.Text=="")
            {
                errorProvider1.SetError(txtuser, "Por favor complete este campo para continuar");
            }
            else if(txtpass.Text=="")
            {
                errorProvider1.SetError(txtpass, "Por favor complete este campo para continuar");
            }
        }
    }
}