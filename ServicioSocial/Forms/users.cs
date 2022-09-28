using ServicioSocial.Forms.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicioSocial
{
    public partial class users : Form
    {

        int pc;
        DataTable dt = new DataTable();

        Users usuario = new Users();
        Validaciones vl = new Validaciones();
        public users()
        {
            InitializeComponent();
        }

        private void tbBuscar_Click(object sender, EventArgs e)
        {

        }

        private void users_Load(object sender, EventArgs e)
        {
            dt = usuario.MostrarDatos();
            dgvbuscar.DataSource = dt;
            usuario.llenarcb(cbcargo);
        }

        public void Limpiar()
        {
            txtnom.Clear();
            txtbuscar.Clear();
            txtapellido.Clear();
            txtcarnet.Clear();
            cbcargo.Text = "";
            txtcorreo.Clear();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
                    
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if(txtbuscar.Text!="")
            {
                if(MessageBox.Show("¿Está seguro que desea eliminar este usuario?","Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1)==DialogResult.Yes)
                {
                    if (usuario.EliminarUsu(txtbuscar.Text))
                        MessageBox.Show("Usuario eliminado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvbuscar.DataSource = usuario.MostrarDatos();
                    Limpiar();
                }
            }
            else
            {
                errorProvider1.SetError(txtbuscar, "Por favor complete este campo para continuar");
            }
            
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if(cbcargo.Text=="" || txtnom.Text == "" || txtapellido.Text == "" || txtcorreo.Text == "" || txtcarnet.Text == "" || textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Por favor rellene todos los campos para continuar", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (textBox1.Text == textBox2.Text)
                {
                    if (cbcargo.Text == "Jefe")
                    {
                        if (usuario.InsertarUsu(txtnom.Text.Trim(), txtapellido.Text.Trim(), 1, txtcorreo.Text.Trim(), textBox1.Text.Trim(), txtcarnet.Text.Trim()))
                        {
                            Limpiar();
                            MessageBox.Show("Usuario registrado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if(cbcargo.Text == "Subjefe")
                    {
                        if (usuario.InsertarUsu(txtnom.Text.Trim(), txtapellido.Text.Trim(), 2, txtcorreo.Text.Trim(), textBox1.Text.Trim(), txtcarnet.Text.Trim().Trim()))
                        {
                            Limpiar();
                            MessageBox.Show("Usuario registrado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if(cbcargo.Text == "Secretaria")
                    {
                        if (usuario.InsertarUsu(txtnom.Text.Trim(), txtapellido.Text.Trim(), 3, txtcorreo.Text.Trim(), textBox1.Text.Trim(), txtcarnet.Text.Trim()))
                        {
                            Limpiar();
                            MessageBox.Show("Usuario registrado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if(cbcargo.Text == "Operador")
                    {
                        if (usuario.InsertarUsu(txtnom.Text.Trim(), txtapellido.Text.Trim(), 4, txtcorreo.Text.Trim(), textBox1.Text.Trim(), txtcarnet.Text.Trim()))
                        {
                            Limpiar();
                            MessageBox.Show("Usuario registrado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cbcargo.Text == "" || txtnom.Text == "" || txtapellido.Text == "" || txtcorreo.Text == "" || txtcarnet.Text == "" || textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Por favor rellene todos los campos para continuar", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if(textBox1.Text.Trim()==textBox2.Text.Trim())
                    {
                        if(cbcargo.Text == "Jefe")
                        {
                            if (usuario.ActualizarUsu(txtnom.Text.Trim(), txtapellido.Text.Trim(), 1, txtcorreo.Text.Trim(), textBox1.Text.Trim(), txtcarnet.Text.Trim()))
                            {
                                Limpiar();
                                MessageBox.Show("Información actualizada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        if (cbcargo.Text == "SubJefe")
                        {
                            if (usuario.ActualizarUsu(txtnom.Text.Trim(), txtapellido.Text.Trim(), 1, txtcorreo.Text.Trim(), textBox1.Text.Trim(), txtcarnet.Text.Trim()))
                            {
                                Limpiar();
                                MessageBox.Show("Información actualizada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        if (cbcargo.Text == "Secretaria")
                        {
                            if (usuario.ActualizarUsu(txtnom.Text.Trim(), txtapellido.Text.Trim(), 1, txtcorreo.Text.Trim(), textBox1.Text.Trim(), txtcarnet.Text.Trim()))
                            {
                                Limpiar();
                                MessageBox.Show("Información actualizada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        if (cbcargo.Text == "Operador")
                        {
                            if (usuario.ActualizarUsu(txtnom.Text.Trim(), txtapellido.Text.Trim(), 1, txtcorreo.Text.Trim(), textBox1.Text.Trim(), txtcarnet.Text.Trim()))
                            {
                                Limpiar();
                                MessageBox.Show("Información actualizada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = $"Carnet LIKE '{txtbuscar.Text}%'";
        }

        private void dgvbuscar_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            pc = dgvbuscar.CurrentRow.Index;
            cbcargo.Text = dgvbuscar[0, pc].Value.ToString();
            txtnom.Text = dgvbuscar[1, pc].Value.ToString();
            txtapellido.Text = dgvbuscar[2, pc].Value.ToString();
            txtcarnet.Text = dgvbuscar[3, pc].Value.ToString();
            txtcorreo.Text = dgvbuscar[4, pc].Value.ToString();
        }

        private void txtcorreo_Leave(object sender, EventArgs e)
        {
            if(vl.email(txtcorreo.Text)==false)
            {
                errorProvider1.SetError(txtcorreo, "Correo invalido");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtcarnet_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtcarnet_Leave(object sender, EventArgs e)
        {
            if(vl.carnet(txtcarnet.Text)==false)
            {
                errorProvider1.SetError(txtcarnet, "Carnet Inválido");
            }
            else
            {
                errorProvider1.Clear();
            }    
        }
    }
}
