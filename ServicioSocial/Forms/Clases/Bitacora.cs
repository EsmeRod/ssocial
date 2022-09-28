using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioSocial.Forms.Clases
{
    internal class Bitacora
    {
        private SqlConnection conexion = new SqlConnection("server= LEVIATHAN; integrated security = true; database= db_alcaldia");
        DataSet ds;
        SqlDataReader rd;

        public DataTable MostrarDatos()
        {
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT\r\n\tCASE evento\r\n\tWHEN 'I' THEN 'Guardar'\r\n\tWHEN 'U' THEN 'Editar'\r\n\tWHEN 'D' THEN 'Eliminar'\r\n\tELSE 'Desconocido'\r\n\tEND as Evento,\r\n\tCASE tipo_reg\r\n\tWHEN 'NEW' THEN 'Nuevo'\r\n\tWHEN 'OLD' THEN 'Antiguo'\r\n\tELSE 'Desconocido'\r\n\tEND as Tipo,\r\n\thostame as Computadora,\r\n\tCONVERT(varchar, FORMAT( fecha, 'dd/mm/yyyy hh:mm:ss')) as Fecha,\r\n\tss.nombre_subserie as Subserie,\r\n\tup.nombre_unidad_productora as 'Unidad productora',\r\n\tu.carnet as Usuario,\r\n\tcodigo_documento as ID,\r\n\tdescripcion as Descripción,\r\n\tanio as Año,\r\n\tubicacion as Ubicación\r\nFROM bitacora_documentos bd\r\nINNER JOIN subseries ss ON bd.id_subserie = ss.id_subserie\r\nINNER JOIN unidades_productoras up ON bd.id_unidad_productora = up.id_unidad_productora \r\nINNER JOIN usuarios u ON bd.id_usuario = u.id_usuario", conexion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds = new DataSet();

                da.Fill(ds, "Bitacora");
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return ds.Tables["Bitacora"];
        }
    }
}
