using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioSocial.Forms.Clases
{
    internal class Users
    {
        private SqlConnection conexion = new SqlConnection("server= DESKTOP-0UKQT82; integrated security = true; database= db_alcaldia");
        DataSet ds;
        SqlDataReader rd;

        public void llenarcb(ComboBox cb)
        {
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("Select nombre_cargo from cargos", conexion);
                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    cb.Items.Add(rd["nombre_cargo"].ToString());
                }

                rd.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {

            }
        }

        public DataTable MostrarDatos()
        {
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT\r\n\tc.nombre_cargo as Cargo,\r\n\ts.nombre as Nombre,\r\n\ts.apellido as Apellido,\r\n\ts.carnet as Carnet,\r\n\ts.correo as Correo\r\nFROM usuarios s\r\nINNER JOIN cargos c ON c.id_cargo = s.id_cargo", conexion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds = new DataSet();

                da.Fill(ds, "Tabla Usuarios");
                conexion.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return ds.Tables["Tabla Usuarios"];
        }

        public bool EliminarUsu(string carnet)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("Delete from usuarios where carnet='" + carnet + "'", conexion);
            int filas = cmd.ExecuteNonQuery();
            conexion.Close();
            if(filas >0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InsertarUsu(string nombre, string apellido, int id_cargo, string correo, string contraseña, string carnet)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO usuarios (id_cargo,nombre,apellido,carnet,correo,contrasenia) VALUES ('"+ Convert.ToString(id_cargo)+"','"+nombre+"','"+apellido+"','"+carnet+"', '"+correo+"', '"+contraseña+"')", conexion);
            int filas = cmd.ExecuteNonQuery();
            conexion.Close();

            if(filas >0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ActualizarUsu(string nombre, string apellido, int id_cargo, string correo, string contraseña, string carnet)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand(String.Format("UPDATE usuarios set nombre='{1}', apellido='{2}', id_cargo='{3}', correo='{4}', contrasenia='{5}' WHERE carnet='{0}'", new string[] {carnet, nombre,apellido,Convert.ToString(id_cargo),correo,contraseña }), conexion);
            int filas = cmd.ExecuteNonQuery();

            conexion.Close();
            if(filas>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
