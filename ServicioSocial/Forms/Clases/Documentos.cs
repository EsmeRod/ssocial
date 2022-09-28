using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ServicioSocial.Forms.Clases
{
   
    public class Documentos
    {
        private SqlConnection conexion = new SqlConnection("server= DESKTOP-0UKQT82 ; database= db_alcaldia ;integrated security = true");
        DataSet ds;
        SqlDataReader rd;

        static public string carnet;
        public DataTable MostrarBuscarUsuario()
        {
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand(string.Format("SELECT \r\n\tss.nombre_subserie as Subserie,\r\n\tup.nombre_unidad_productora as 'Unidad productora',\r\n\tu.carnet as Usuario,\r\n\tcodigo_documento as ID,\r\n\tdescripcion as Descripción,\r\n\tanio as Año,\r\n\tubicacion as Ubicación\r\nFROM documentos d\r\nINNER JOIN usuarios u on d.id_usuario=u.id_usuario \r\nINNER JOIN subseries ss on d.id_subserie=ss.id_subserie\r\nINNER JOIN unidades_productoras up on d.id_unidad_productora=up.id_unidad_productora"), conexion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds = new DataSet();

                da.Fill(ds, "Documentos");
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return ds.Tables["Documentos"];
        }

        public void llenarcbsub(ComboBox cb)
        {
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("Select nombre_subserie from subseries", conexion);
                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    cb.Items.Add(rd["nombre_subserie"].ToString());
                }

                rd.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {

            }
        }

        public void llenarcbuni(ComboBox cb)
        {
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("Select nombre_unidad_productora from unidades_productoras", conexion);
                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    cb.Items.Add(rd["nombre_unidad_productora"].ToString());
                }

                rd.Close();
                conexion.Close();
            }
            catch (Exception ex)
            {

            }
        }

        public bool InsertarDoc(string sub, string unidad, string codigo, string ubicacion, string año, string des, string carnet)
        {
            SqlCommand cmd = new SqlCommand("InsertarDoc", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter subseccion = new SqlParameter("@subs", sub);
            subseccion.Direction = ParameterDirection.Input;

            SqlParameter unit = new SqlParameter("@unidad", unidad);
            unit.Direction = ParameterDirection.Input;

            SqlParameter cod = new SqlParameter("@codigodoc", codigo);
            cod.Direction = ParameterDirection.Input;

            SqlParameter ub = new SqlParameter("@ubicacion", ubicacion);
            ub.Direction = ParameterDirection.Input;

            SqlParameter an = new SqlParameter("@año", año);
            an.Direction = ParameterDirection.Input;

            SqlParameter descripcion = new SqlParameter("@descripcion", des);
            descripcion.Direction = ParameterDirection.Input;
            SqlParameter car = new SqlParameter("@carnet", carnet);
            car.Direction = ParameterDirection.Input;

            cmd.Parameters.Add(subseccion);
            cmd.Parameters.Add(unit);
            cmd.Parameters.Add(cod);
            cmd.Parameters.Add(ub);
            cmd.Parameters.Add(an);
            cmd.Parameters.Add(descripcion);
            cmd.Parameters.Add(car);

            try
            {
                conexion.Open();
                int filas = cmd.ExecuteNonQuery();
                if(filas>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return true;
        }
        public bool ActualizarDoc(string sub, string unidad, string codigo, string ubicacion, string año, string des, string carnet)
        {
            SqlCommand cmd = new SqlCommand("UpdateDoc", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter subseccion = new SqlParameter("@subs", sub);
            subseccion.Direction = ParameterDirection.Input;

            SqlParameter unit = new SqlParameter("@unidad", unidad);
            unit.Direction = ParameterDirection.Input;

            SqlParameter cod = new SqlParameter("@codigodoc", codigo);
            cod.Direction = ParameterDirection.Input;

            SqlParameter ub = new SqlParameter("@ubicacion", ubicacion);
            ub.Direction = ParameterDirection.Input;

            SqlParameter an = new SqlParameter("@año", año);
            an.Direction = ParameterDirection.Input;

            SqlParameter descripcion = new SqlParameter("@descripcion", des);
            descripcion.Direction = ParameterDirection.Input;
            SqlParameter car = new SqlParameter("@carnet", carnet);
            car.Direction = ParameterDirection.Input;

            cmd.Parameters.Add(subseccion);
            cmd.Parameters.Add(unit);
            cmd.Parameters.Add(cod);
            cmd.Parameters.Add(ub);
            cmd.Parameters.Add(an);
            cmd.Parameters.Add(descripcion);
            cmd.Parameters.Add(car);

            try
            {
                conexion.Open();
                int filas = cmd.ExecuteNonQuery();
                if (filas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return true;
        }
        public bool EliminarDoc(string sub, string unidad, string codigo, string ubicacion, string año, string des, string carnet)
        {
            SqlCommand cmd = new SqlCommand("DeleteDoc", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter subseccion = new SqlParameter("@subs", sub);
            subseccion.Direction = ParameterDirection.Input;

            SqlParameter unit = new SqlParameter("@unidad", unidad);
            unit.Direction = ParameterDirection.Input;

            SqlParameter cod = new SqlParameter("@codigodoc", codigo);
            cod.Direction = ParameterDirection.Input;

            SqlParameter ub = new SqlParameter("@ubicacion", ubicacion);
            ub.Direction = ParameterDirection.Input;

            SqlParameter an = new SqlParameter("@año", año);
            an.Direction = ParameterDirection.Input;

            SqlParameter descripcion = new SqlParameter("@descripcion", des);
            descripcion.Direction = ParameterDirection.Input;
            SqlParameter car = new SqlParameter("@carnet", carnet);
            car.Direction = ParameterDirection.Input;

            cmd.Parameters.Add(subseccion);
            cmd.Parameters.Add(unit);
            cmd.Parameters.Add(cod);
            cmd.Parameters.Add(ub);
            cmd.Parameters.Add(an);
            cmd.Parameters.Add(descripcion);
            cmd.Parameters.Add(car);

            try
            {
                conexion.Open();
                int filas = cmd.ExecuteNonQuery();
                if (filas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return true;
        }
    }
}
