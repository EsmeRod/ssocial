using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicioSocial.Forms.Clases
{
    class Login
    {
        private SqlDataReader rd;
        private SqlConnection conexion = new SqlConnection("server= DESKTOP-0UKQT82; integrated security = true; database= db_alcaldia");
       
        public void Logeo(string usuario, string contra)
        {
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand(String.Format("Select nombre, id_cargo from usuarios WHERE carnet ='" + usuario + "' AND contrasenia ='" + contra + "'"), conexion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    if (dt.Rows[0][1].ToString() == "1")
                    {
                        main hm = new main();
                        hm.Show();
                        hm.label1.Text = "Bienvenido/a" + dt.Rows[0][0].ToString();
                        login ln = new login();
                        ln.Close();
                    }
                    else if (dt.Rows[0][1].ToString() == "2")
                    {
                        main mn = new main();
                        mn.label1.Text = "Bienvenido/a" + dt.Rows[0][0].ToString();
                        mn.btnbitacora.Visible = false;
                        mn.btnuser.Visible = false;
                        login ln = new login();
                        ln.Close();
                        mn.Show();
                    }
                    else if (dt.Rows[0][1].ToString() == "3")
                    {
                        main mn = new main();
                        mn.label1.Text = "Bienvenido/a" + dt.Rows[0][0].ToString();
                        mn.btnbitacora.Visible = false;
                        mn.btnuser.Visible = false;
                        login ln = new login();
                        ln.Close();
                        mn.Show();
                    }
                    else if (dt.Rows[0][1].ToString() == "4")
                    {
                        main mn = new main();
                        mn.label1.Text = "Bienvenido/a" + dt.Rows[0][0].ToString();
                        mn.btnbitacora.Visible = false;
                        mn.btnuser.Visible = false;
                        login ln = new login();
                        ln.Close();
                        mn.Show();
                    }
                    else
                    {
                        MessageBox.Show("El usuario o la contraseña son incorrectos", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }

                    rd.Close();
                    conexion.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error\n" + ex.ToString());
                conexion.Close();
            }
            
        }
    }
}
