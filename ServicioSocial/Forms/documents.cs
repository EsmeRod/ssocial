using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ServicioSocial.Forms.Clases;

namespace ServicioSocial
{
    public partial class documents : Form
    {
        DataTable dt = new DataTable();
        Documentos doc = new Documentos();
        Validaciones val = new Validaciones();
        public documents()
        {
            InitializeComponent();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

        }

        private void documents_Load(object sender, EventArgs e)
        {
            dt = doc.MostrarBuscarUsuario();
            dgvbuscar.DataSource = dt;
           // dgvbuscar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            cmbfiltro.SelectedIndex = 1;
            doc.llenarcbsub(cbSubS);
            doc.llenarcbuni(cbUnidad);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            if (cmbfiltro.SelectedIndex == 0)
            {
                dt.DefaultView.RowFilter = $"ID LIKE '{txtbuscar.Text}%'";
            }

            if (cmbfiltro.SelectedIndex == 1)
            {
                dt.DefaultView.RowFilter = $"Año LIKE '{txtbuscar.Text}%'";
            }

            if (cmbfiltro.SelectedIndex == 2)
            {
                dt.DefaultView.RowFilter = $"Ubicación LIKE '{txtbuscar.Text}%'";
            }
        }

        private void tabbus_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string codigo = txtcod.Text + txtcorrelativo.Text;

            if(doc.InsertarDoc(cbSubS.Text,cbUnidad.Text,codigo,txtubicacion.Text,txtaño.Text,txtdescripcion.Text, Documentos.carnet))
            {
                MessageBox.Show("Ingresado");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}
